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
    public partial class ClientControl : UserControl
    {
        public Client Client { get; set; }
        public ClientControl(Client client)
        {
            InitializeComponent();
            Client = client;

            FLPValue.Text = Client.Surname + " " + Client.Name[0] + ". ";
            if (client.Partonymic != "")
                FLPValue.Text += Client.Partonymic[0] + ".";
            inpValue.Text = Client.Inp.ToString();
            passportNumberValue.Text = Client.PassportNumber.ToString();
            phoneNumberValue.Text = Client.PhoneNumber.ToString();

            if (Client.Sex == Sex.female)
                sexValue.Text = "жін";
            else
                sexValue.Text = "чол";
            dateBirthValue.Text = Client.DateBirth.ToShortDateString();
            amountUAH.Text = Client.GetBalanceUAH().ToString();
            amountEUR.Text = Client.GetBalanceEUR().ToString();
            amountUSD.Text = Client.GetBalanceUSD().ToString();
        }

        private void userPb_Click(object sender, EventArgs e)
        {
            Form currentForm = this.FindForm();
            currentForm.Hide();
            AdministratorAddEditClient form = new AdministratorAddEditClient(Client);
            form.ShowDialog();
        }
    }
}
