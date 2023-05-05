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
    public partial class AdministratorMenu : Form
    {
        public AdministratorMenu()
        {
            InitializeComponent();
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

        private void clientsBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdministratorClients form = new AdministratorClients();
            form.Show();
        }

        private void depositProgramsBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdministratorDepositPrograms form = new AdministratorDepositPrograms();
            form.Show();
        }

        private void AdministratorMenu_FormClosing(object sender, FormClosingEventArgs e)
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
