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
    public partial class ClientAccount : Form
    {
        Client Client { get; set; }

        public ClientAccount(Client client)
        {
            InitializeComponent();
            Client = client;

            user.Text = Client.Surname + " " + Client.Name[0] + ". ";
            if (Client.Partonymic != "")
                user.Text += Client.Partonymic[0] + ".";

            if (DataBase.Instance.Deposits.GetDepositsByInp(Client.Inp).Count() == 0)
            {
                depositsPanel.Visible = false;
            }
            else
            {
                LoadCards();
            } 
        }

        private void LoadCards()
        {
            amountUAH.Text = Client.GetBalanceUAH() + " UAH";
            amountUSD.Text = Client.GetBalanceUSD() + " USD";
            amountEUR.Text = Client.GetBalanceEUR() + " EUR";

            backP.Visible = false;
            textBackP.Visible = false;
            depositsPanel.Controls.Clear();
            ClientDepositControl clientDepositControl;
            
            foreach (Deposit deposit in DataBase.Instance.Deposits.GetDepositsByInp(Client.Inp))
            {
                clientDepositControl = new ClientDepositControl(deposit);
                clientDepositControl.UpdateFlowLayout += Control_UpdateFlowLayout;

                depositsPanel.Controls.Add(clientDepositControl);
            }
        }

        private void Control_UpdateFlowLayout(object sender, EventArgs e)
        {
            LoadCards();
        }

        private void back_Click(object sender, EventArgs e)
        {
            DataBase.Instance.Clients.SerializeObject("clients");
            DataBase.Instance.DepositPrograms.SerializeObject("depositPrograms");
            DataBase.Instance.Deposits.SerializeObject("deposits");
            Hide();
            Authorization form = new Authorization();
            form.Show();
        }

        private void openBtn_Click(object sender, EventArgs e)
        {
            Hide();
            ClientAddDeposit form = new ClientAddDeposit(Client);
            form.Show();
        }

        private void infoBtn_Click(object sender, EventArgs e)
        {
            Hide();
            ClientInfo form = new ClientInfo(Client);
            form.Show();
        }

        private void ClientAccount_FormClosing(object sender, FormClosingEventArgs e)
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
