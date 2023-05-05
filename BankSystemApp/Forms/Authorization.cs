using BankSystemModel;
using System;
using System.Windows.Forms;

namespace BankSystemApp
{
    public partial class Authorization : Form
    {
        BankSystem bankSystem = new BankSystem();
        public Authorization()
        {
            InitializeComponent();
            DataBase.Instance.Clients.DeserializeObject("clients");
            DataBase.Instance.DepositPrograms.DeserializeObject("depositPrograms");
            DataBase.Instance.Deposits.DeserializeObject("deposits");
        }

        private void logInBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string inp = inpTb.Text;
                string password = passwordTb.Text;
                Client? curentUser;
                if (inp.Length > 0 && password.Length > 0)
                {
                    if (inp != BankSystem.ADMIN_LOGIN && password != BankSystem.ADMIN_PASSWORD)
                    {
                        curentUser = bankSystem.dataBase.Clients.FindByInp(long.Parse(inp));
                        if (curentUser != null && curentUser.Password == password)
                        {
                            this.Hide();
                            ClientAccount form = new ClientAccount(curentUser);
                            form.ShowDialog();
                        }
                        else if (curentUser != null && curentUser.Password != password)
                        {
                            throw new FormatException("Невірний пароль!");
                        }
                        else
                        {
                            throw new Exception("Користувача не знайдено!");
                        }
                    }
                    else if (inp == BankSystem.ADMIN_LOGIN && password == BankSystem.ADMIN_PASSWORD)
                    {
                        this.Hide();
                        AdministratorMenu form = new AdministratorMenu();
                        form.ShowDialog();
                    }
                    else
                    {
                        throw new Exception("Користувача не знайдено!");
                    }
                }
                else
                {
                    throw new FormatException("Логін або пароль введено некоректно!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Повідомлення", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                inpTb.Text = "";
                passwordTb.Text = "";
            }          
        }

        private void Authorization_FormClosing(object sender, FormClosingEventArgs e)
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