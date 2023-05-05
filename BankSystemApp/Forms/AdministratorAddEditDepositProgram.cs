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
    public partial class AdministratorAddEditDepositProgram : Form
    {
        DepositProgram DepositProgram { get; set; }
        public AdministratorAddEditDepositProgram()
        {
            InitializeComponent();
            deleteBtn.Visible = false;
        }
        public AdministratorAddEditDepositProgram(DepositProgram depositProgram)
        {
            InitializeComponent();

            DepositProgram = depositProgram;
            LoadInfo();
        }

        private void LoadInfo()
        {
            acceptBtn.Text = "  Відредагувати";
            nameTb.Enabled = false;
            typeCb.Enabled = false;
            currencyTypeCb.Enabled = false;
            nameTb.Text = DepositProgram.Name;
            if (DepositProgram.Type == TypeDeposit.TimeDeposit)
                typeCb.SelectedIndex = 0;
            else
                typeCb.SelectedIndex = 1;

            if (DepositProgram.CurrencyType == CurrencyType.UAH)
                currencyTypeCb.SelectedIndex = 0;
            else if (DepositProgram.CurrencyType == CurrencyType.USD)
                currencyTypeCb.SelectedIndex = 1;
            else
                currencyTypeCb.SelectedIndex = 2;
            percentMonth3Tb.Text = (DepositProgram.InterestRates.FirstOrDefault(x => x.Key == 3).Value * 100).ToString();
            percentMonth6Tb.Text = (DepositProgram.InterestRates.FirstOrDefault(x => x.Key == 6).Value * 100).ToString();
            percentMonth9Tb.Text = (DepositProgram.InterestRates.FirstOrDefault(x => x.Key == 9).Value * 100).ToString();
            percentMonth12Tb.Text = (DepositProgram.InterestRates.FirstOrDefault(x => x.Key == 12).Value * 100).ToString();
        }

        private void acceptBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string name = nameTb.Text;
                TypeDeposit type = (TypeDeposit)typeCb.SelectedIndex;
                CurrencyType currencyType = (CurrencyType)currencyTypeCb.SelectedIndex;
                decimal percentMonth3 = decimal.Parse(percentMonth3Tb.Text) / 100;
                decimal percentMonth6 = decimal.Parse(percentMonth6Tb.Text) / 100;
                decimal percentMonth9 = decimal.Parse(percentMonth9Tb.Text) / 100;
                decimal percentMonth12 = decimal.Parse(percentMonth12Tb.Text) / 100;
                Dictionary<int, decimal> interestRates = new Dictionary<int, decimal>
                {
                    { 3, percentMonth3 },
                    { 6, percentMonth6 },
                    { 9, percentMonth9 },
                    { 12, percentMonth12 }
                };

                if (currencyTypeCb.SelectedIndex == -1 || typeCb.SelectedIndex == -1)
                {
                    throw new FormatException("Перевірте правильність заповнення полів Тип та Валюта!");
                }

                if (acceptBtn.Text == "  Відредагувати")
                {
                    DataBase.Instance.DepositPrograms.Update(name, interestRates);
                    MessageBox.Show("Депозитну програму відредаговано!", "Повідомлення", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    DataBase.Instance.DepositPrograms.Add(name, type, currencyType, interestRates);
                    MessageBox.Show("Депозитну програму додано!", "Повідомлення", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                Hide();
                AdministratorDepositPrograms form = new AdministratorDepositPrograms();
                form.Show();
            }
            catch (Exception ex) 
            {
                MessageBox.Show($"{ex.Message}", "Повідомлення", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); 
            }
        }

        private void back_Click(object sender, EventArgs e)
        {
            Hide();
            AdministratorDepositPrograms form = new AdministratorDepositPrograms();
            form.Show();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string name = nameTb.Text;
                DialogResult result = MessageBox.Show("Ви впевнені, що хочете видалити депозитну програму?", "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    if (DataBase.Instance.DepositPrograms.RemoveByName(name))
                    {
                        MessageBox.Show("Депозитну програму видалено!", "Повідомлення", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Hide();
                        AdministratorDepositPrograms form = new AdministratorDepositPrograms();
                        form.Show();
                    }
                    else
                    {
                        MessageBox.Show("Депозитну програму НЕ видалено!\nУмовою видалення є відсутні відкриті депозити за цією програмою!", "Повідомлення", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }  
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Повідомлення", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void AdministratorAddEditDepositProgram_FormClosing(object sender, FormClosingEventArgs e)
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
