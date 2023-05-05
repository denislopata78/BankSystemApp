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
    public partial class ClientInfo : Form
    {
        Client Client { get; set; }
        public ClientInfo(Client client)
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
            amountUAH.Text = Client.GetBalanceUAH() + " UAH";
            amountUSD.Text = Client.GetBalanceUSD() + " USD";
            amountEUR.Text = Client.GetBalanceEUR() + " EUR";

            nameTb.Text = Client.Name;
            surnameTb.Text = Client.Surname;
            partonymicTb.Text = Client.Partonymic;
            inpTb.Text = Client.Inp.ToString();
            passportNumberTb.Text = Client.PassportNumber;
            phoneNumberTb.Text = Client.PhoneNumber;
            if (Client.Sex == Sex.male)
                sexCb.SelectedIndex = 0;
            else if (Client.Sex == Sex.female)
                sexCb.SelectedIndex = 1;
            dateBirthDtp.Value = Client.DateBirth;
            adressTb.Text = Client.Adress;
            passwordTb.Text = Client.Password;

            nameTb.Enabled = false;
            surnameTb.Enabled = false;
            partonymicTb.Enabled = false;
            inpTb.Enabled = false;
            passportNumberTb.Enabled = false;
            sexCb.Enabled = false;
            dateBirthDtp.Enabled = false;
        }

        private void back_Click(object sender, EventArgs e)
        {
            Hide();
            ClientAccount form = new ClientAccount(Client);
            form.Show();
        }

        private void acceptBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string phoneNumber = phoneNumberTb.Text;
                string adress = adressTb.Text;
                string password = passwordTb.Text;

                DataBase.Instance.Clients.Update(Client.Name, Client.Surname, Client.Inp, Client.PassportNumber, phoneNumber, adress, password);
                MessageBox.Show("Інформацію відредаговано!", "Повідомлення", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Hide();
                ClientAccount form = new ClientAccount(Client);
                form.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Повідомлення", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void hidePb_Click(object sender, EventArgs e)
        {
            if (passwordTb.PasswordChar == '*')
            {
                passwordTb.PasswordChar = '\0';
            }
            else
            {
                passwordTb.PasswordChar = '*';
            }
        }

        private void ClientInfo_FormClosing(object sender, FormClosingEventArgs e)
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
