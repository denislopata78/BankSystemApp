using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace BankSystemModel
{
    public class DemandDeposit : Deposit, IWithdrawable
    {
        public DemandDeposit(long inp, string name, DepositProgram depositProgram, decimal amount, int duration, DateTime openDate)
            : base(inp, name, depositProgram, amount, duration, openDate)
        {
            DepositType = DepositProgram.Type.ToString();
        }

        public bool Withdraw(decimal amountToWithdraw)
        {
            if (amountToWithdraw <= 0 || amountToWithdraw > Amount || (DepositProgram.CurrencyType == CurrencyType.UAH && Amount - amountToWithdraw < 1000) || Amount - amountToWithdraw < 100)
            {
                return false;
            }

            DateTime monthsAgo = DateTime.Now.AddMonths(-Duration);
            if (OpenDate <= monthsAgo)
            {
                Amount += CalculateInterest();
                Amount -= amountToWithdraw;
            }
            else
            {
                Amount = Amount - amountToWithdraw;  
            }
            OpenDate = DateTime.Now;
            return true;
        }

        public override decimal CalculateInterest()
        {
            decimal percent = 0;
            if (Duration == 3)
                percent = DepositProgram.InterestRates[3] * Duration / 12;
            else if (Duration == 6)
                percent = DepositProgram.InterestRates[6] * Duration / 12;
            else if (Duration == 9)
                percent = DepositProgram.InterestRates[9] * Duration / 12;
            else if (Duration == 12)
                percent = DepositProgram.InterestRates[12];
            return (Amount / 100 * percent) - ((Amount / 100 * percent) / 100 * TaxOnIncome);
        }
    }
}
