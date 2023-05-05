using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace BankSystemModel
{
    public class TimeDeposit: Deposit
    {
        private decimal paymentPerMonth;
        public decimal PaymentPerMonth
        {
            get { return paymentPerMonth; }
            set
            {
                if (value == 0) 
                {
                    paymentPerMonth = value;
                }
                else if (value < 100 && DepositProgram.CurrencyType == CurrencyType.UAH)
                {
                    throw new FormatException("Сума мінімального щомісячного поповнення повинна бути більше або дорівнювати 100 грн.");
                }
                else if (value < 10)
                {
                    throw new FormatException("Сума мінімального щомісячного поповнення повинна бути більше або дорівнювати 10$/10€");
                }
                paymentPerMonth = value;
            }
        }


        public TimeDeposit(long inp, string name, DepositProgram depositProgram, decimal amount, decimal paymentPerMonth, int duration, DateTime openDate)
            : base(inp, name, depositProgram, amount, duration, openDate)
        {
            PaymentPerMonth = paymentPerMonth;
            DepositType = DepositProgram.Type.ToString();
        }

        public decimal GetAmount()
        {
            return Amount + PaymentPerMonth * Duration;
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
            return (GetAmount() / 100 * percent) - ((GetAmount() / 100 * percent) / 100 * TaxOnIncome);
        }
    }
}
