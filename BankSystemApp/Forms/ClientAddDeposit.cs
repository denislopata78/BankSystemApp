using BankSystemModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BankSystemApp
{
    public partial class ClientAddDeposit : Form
    {
        Client Client { get; set; }
        public ClientAddDeposit(Client client)
        {
            InitializeComponent();

            Client = client;
            LoadInfo();
        }

        public void LoadInfo()
        {
            user.Text = Client.Surname + " " + Client.Name[0] + ". ";
            if (Client.Partonymic != "")
                user.Text += Client.Partonymic[0] + ".";
            amountUAH.Text = Client.GetBalanceUAH() + " ₴";
            amountUSD.Text = Client.GetBalanceUSD() + " $";
            amountEUR.Text = Client.GetBalanceEUR() + " €";

            List<string> items = new List<string>() { };
            foreach (DepositProgram depositProgram in DataBase.Instance.DepositPrograms)
            {
                items.Add(depositProgram.Name);
            }
            depositProgramsCb.DataSource = items;
        }

        private void depositProgramsCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            string? depositProgramName = depositProgramsCb.SelectedItem.ToString();
            if (depositProgramName != null)
            {
                DepositProgram depositProgram = DataBase.Instance.DepositPrograms.FirstOrDefault(depositProgram => depositProgram.Name == depositProgramName);
               if (depositProgram.Type == TypeDeposit.TimeDeposit)
               {
                    typeValue.Text = "Строковий";
                    paymentPerMonthTb.Enabled = true;
                }   
               else if (depositProgram.Type == TypeDeposit.DemandDeposit)
               {
                    typeValue.Text = "До запитання";
                    paymentPerMonthTb.Text = "0";
                    paymentPerMonthTb.Enabled = false;
               }
                    
               currenctTypeValue.Text = depositProgram.CurrencyType.ToString();
                if (depositProgram.Type == TypeDeposit.DemandDeposit)
                    withdrawValue.Text = "так";
                else
                    withdrawValue.Text = "ні";
                percentMonth3.Text = $"{depositProgram.InterestRates[3] * 100} %";
                percentMonth6.Text = $"{depositProgram.InterestRates[6] * 100} %";
                percentMonth9.Text = $"{depositProgram.InterestRates[9] * 100} %";
                percentMonth12.Text = $"{depositProgram.InterestRates[12] * 100} %";
            }
        }

        private void acceptBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (durationCb.SelectedIndex == -1 || depositProgramsCb.SelectedIndex == -1)
                {
                    throw new FormatException("Перевірте правильність заповнення поля вибору депозитної програми та поля Тривалість!");
                }
                DepositProgram depositProgram = DataBase.Instance.DepositPrograms.FirstOrDefault(depositProgram => depositProgram.Name == depositProgramsCb.SelectedItem);
                string name = nameTb.Text;
                int duration = int.Parse(durationCb.SelectedItem.ToString());
                decimal amount = decimal.Parse(amountTb.Text);
                bool result = false;

                if (depositProgram.Type == TypeDeposit.TimeDeposit)
                {
                    decimal paymentPerMonth = decimal.Parse(paymentPerMonthTb.Text);
                    result = DataBase.Instance.Deposits.Add(Client.Inp, name, depositProgram, amount, paymentPerMonth, duration, DateTime.Now);
                }
                else if (depositProgram.Type == TypeDeposit.DemandDeposit)
                {
                    result = DataBase.Instance.Deposits.Add(Client.Inp, name, depositProgram, amount, 0, duration, DateTime.Now);
                }

                if (result)
                {
                    MessageBox.Show("Депозит створено!", "Повідомлення", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Hide();
                    ClientAccount form = new ClientAccount(Client);
                    form.Show();
                }
                else
                {
                    MessageBox.Show("Депозит НЕ створено! Перевірте введені дані!\nМожливо депозит з таким ім'ям вже існує!", "Повідомлення", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Повідомлення", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void back_Click(object sender, EventArgs e)
        {
            Hide();
            ClientAccount form = new ClientAccount(Client);
            form.Show();
        }

        private void ClientAddDeposit_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                DialogResult result = MessageBox.Show("Ви впевнені, що хочете вийти?", "Повідомлення", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result != DialogResult.Yes)
                {
                    e.Cancel = true;
                }
                else
                {
                    DataBase.Instance.Clients.SerializeObject("clients");
                    DataBase.Instance.DepositPrograms.SerializeObject("depositPrograms");
                    DataBase.Instance.Deposits.SerializeObject("deposits");
                    Application.Exit();
                }
            }
        }
    }
}
