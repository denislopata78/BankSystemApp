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
    public partial class AdministratorDepositPrograms : Form
    {
        public AdministratorDepositPrograms()
        {
            InitializeComponent();
            LoadCards();
        }

        private void addDepositProgramBtn_Click(object sender, EventArgs e)
        {
            Hide();
            AdministratorAddEditDepositProgram form = new AdministratorAddEditDepositProgram();
            form.Show();
        }

        private void LoadCards()
        {
            DepositProgramControl depositProgramControl;
            foreach (DepositProgram depositProgram in DataBase.Instance.DepositPrograms)
            {
                depositProgramControl = new DepositProgramControl(depositProgram);
                depositProgramsPanel.Controls.Add(depositProgramControl);
            }
        }

        private void back_Click(object sender, EventArgs e)
        {
            Hide();
            AdministratorMenu form = new AdministratorMenu();
            form.Show();
        }

        private void AdministratorDepositPrograms_FormClosing(object sender, FormClosingEventArgs e)
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
