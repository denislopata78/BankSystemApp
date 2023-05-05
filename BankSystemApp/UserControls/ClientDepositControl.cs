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
    public partial class ClientDepositControl : UserControl
    {
        public Deposit Deposit { get; set; }
        public event EventHandler UpdateFlowLayout;

        public ClientDepositControl(Deposit deposit)
        {
            InitializeComponent();

            Deposit = deposit;
            LoadCard();
        }

        private void LoadCard()
        {
            nameValue.Text = Deposit.Name;
            depositProgramValue.Text = Deposit.DepositProgram.Name;
            if (Deposit.DepositProgram.Type == TypeDeposit.DemandDeposit)
                depositTypeValue.Text = "До запитання";
            else
                depositTypeValue.Text = "Строковий";
            openDateValue.Text = Deposit.OpenDate.ToShortDateString();
            endDateValue.Text = Deposit.OpenDate.AddMonths(Deposit.Duration).ToShortDateString();
            interestValue.Text = (Deposit.DepositProgram.InterestRates.GetValueOrDefault(Deposit.Duration) * 100).ToString() + " %";
            if (Deposit is TimeDeposit)
            {
                TimeDeposit timeDeposit = Deposit as TimeDeposit;
                paymentPerMonthValue.Text = timeDeposit.PaymentPerMonth.ToString() + " " + Deposit.DepositProgram.CurrencyType;
                profitValue.Text = "+ " + Math.Round(timeDeposit.CalculateInterest(), 2).ToString() + " " + Deposit.DepositProgram.CurrencyType;
                amountValue.Text = timeDeposit.GetAmount().ToString() + " " + Deposit.DepositProgram.CurrencyType;
                withdrawBtn.Enabled = false;
            }
            else
            {
                paymentPerMonthValue.Text = "-";
                profitValue.Text = "+ " + Math.Round(Deposit.CalculateInterest(), 2).ToString() + " " + Deposit.DepositProgram.CurrencyType;
                amountValue.Text = Deposit.Amount.ToString() + " " + Deposit.DepositProgram.CurrencyType;
            }
            DateTime monthsAgo;
            monthsAgo = DateTime.Now.AddMonths(-Deposit.Duration);
            if (Deposit.OpenDate <= monthsAgo)
            {
                closeBtn.BackColor = Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(222)))), ((int)(((byte)(164)))));
            }
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            decimal balance;
            DialogResult dialogResult = MessageBox.Show("Ви впевнені, що хочете закрити депозит?\nЯкщо строк не добіг кінця відсотки будуть анульовані.", "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                bool result = DataBase.Instance.Deposits.Remove(Deposit, out balance);

                if (result)
                {
                    MessageBox.Show($"Депозит успішно закрито!\nОтримайте Ваші кошти: {Math.Round(balance, 2)} {Deposit.DepositProgram.CurrencyType}", "Повідомлення", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    UpdateFlowLayout?.Invoke(this, EventArgs.Empty);
                }
                else
                {
                    MessageBox.Show("Помилка при закритті!\nСтрок депозиту типу Строковий не добіг кінця!", "Повідомлення", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void withdrawBtn_Click(object sender, EventArgs e)
        {
            if (Deposit is DemandDeposit)
            {   
                ClientWithdraw form = new ClientWithdraw(Deposit as DemandDeposit);
                form.ShowDialog();
                UpdateFlowLayout?.Invoke(this, EventArgs.Empty);
            }
        }
    }
}
