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
    public partial class ClientWithdraw : Form
    {
        DemandDeposit Deposit { get; set; }
        decimal amountToWithdraw;
        public event EventHandler UpdateFlowLayout;
        public ClientWithdraw(DemandDeposit demandDeposit)
        {
            InitializeComponent();
            Deposit = demandDeposit;
        }

        private void acceptBtn_Click(object sender, EventArgs e)
        {
            try
            {
                amountToWithdraw = int.Parse(amountTb.Text);
                Deposit.BalanceChanged += Deposit_BalanceChanged;
                bool result = Deposit.Withdraw(amountToWithdraw);
                Deposit.BalanceChanged -= Deposit_BalanceChanged;
                if (result)
                {
                    DataBase.Instance.Deposits.SerializeObject("deposits");
                    Close();
                }
                else
                {
                    throw new FormatException("Сума для знятта повинна бути в межах наявних коштів.\nТакож на депозиті повинно залишитись хоча б 1000грн./100$/100€!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Повідомлення", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void Deposit_BalanceChanged(object sender, EventArgs e)
        {
            MessageBox.Show($"Зняття {amountToWithdraw} {Deposit.DepositProgram.CurrencyType} пройшло успішно!", "Повідомлення", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
