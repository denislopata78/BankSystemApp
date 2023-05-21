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
    public partial class AdministratorClients : Form
    {
        public AdministratorClients()
        {
            InitializeComponent();
            LoadCards();
        }

        private void LoadCards()
        {
            clientPanel.Controls.Clear();
            ClientControl clientControl;
            DataBase.Instance.Clients.Sort();
            foreach (Client client in DataBase.Instance.Clients)
            {
                clientControl = new ClientControl(client);
                clientPanel.Controls.Add(clientControl);
            }
        }

        private void addClientBtn_Click(object sender, EventArgs e)
        {
            Hide();
            AdministratorAddEditClient form = new AdministratorAddEditClient();
            form.ShowDialog();
        }

        private void back_Click(object sender, EventArgs e)
        {
            Hide();
            AdministratorMenu form = new AdministratorMenu();
            form.ShowDialog();
        }

        private void searchPb_Click(object sender, EventArgs e)
        {
            try
            {
                long inpToSearch = long.Parse(searchTb.Text);
                Client client = DataBase.Instance.Clients.FindByInp(inpToSearch);
                if (client != null)
                {
                    clientPanel.Controls.Clear();
                    ClientControl clientControl = new ClientControl(client);
                    clientPanel.Controls.Add(clientControl);
                }
                else
                {
                    clientPanel.Controls.Clear();
                    MessageBox.Show("Клієнта не знайдено!", "Повідомлення", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Виникла помилка!\n{ex.Message}", "Повідомлення", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void subtitlePb_Click(object sender, EventArgs e)
        {
            LoadCards();
        }

        private void AdministratorClients_FormClosing(object sender, FormClosingEventArgs e)
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
