using BankSystemModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankSystemApp
{
    public partial class ClientDepositMiniControl : UserControl
    {
        public ClientDepositMiniControl(Deposit deposit)
        {
            InitializeComponent();

            nameValue.Text = deposit.Name;
            depositProgramValue.Text = deposit.DepositProgram.Name;
            if (deposit.DepositProgram.Type == TypeDeposit.DemandDeposit)
                depositTypeValue.Text = "До запитання";
            else
                depositTypeValue.Text = "Строковий";
            openDateValue.Text = deposit.OpenDate.ToShortDateString();
            endDateValue.Text = deposit.OpenDate.AddMonths(deposit.Duration).ToShortDateString();
            interestValue.Text = Math.Round(deposit.CalculateInterest(), 2).ToString() + " " + deposit.DepositProgram.CurrencyType;
            amountValue.Text = deposit.Amount.ToString() + " " + deposit.DepositProgram.CurrencyType;
        }
    }
}
