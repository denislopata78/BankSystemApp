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
    public partial class AdministratorAddEditClient : Form
    {
        Client Client { get; set; }
        public AdministratorAddEditClient()
        {
            InitializeComponent();

            info2Pb.Visible = false;
            info2.Visible = false;
            depositsClientPanel.Visible = false;
            deleteBtn.Visible = false;
        }

        public AdministratorAddEditClient(Client client)
        {
            InitializeComponent();

            Client = client;
            LoadInfo();
        }

        private void LoadInfo()
        {
            acceptBtn.Text = "  Відредагувати";
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

            password.Visible = false;
            passwordTb.Visible = false;

            if (Client.GetDeposits().Count == 0)
            {
                info2Pb.Visible = false;
                info2.Visible = false;
                depositsClientPanel.Visible = false;
            }
            else
            {
                depositsClientPanel.Controls.Clear();
                ClientDepositMiniControl clientDepositMiniControl;
                foreach (Deposit deposit in DataBase.Instance.Deposits)
                {
                    if (deposit.Inp.ToString() == inpTb.Text)
                    {
                        clientDepositMiniControl = new ClientDepositMiniControl(deposit);
                        depositsClientPanel.Controls.Add(clientDepositMiniControl);
                    } 
                }
            }

            if (Client.GetDeposits().Count == 0)
            {
                deleteBtn.Size = new Size(168, 31);
                deleteBtn.Location = new Point(702, 397);
                deleteBtn.Text = "       Видалити ";
            }

            partonymicTb.Enabled = false;
            inpTb.Enabled = false;
            sexCb.Enabled = false;
            dateBirthDtp.Enabled = false;
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdministratorClients form = new AdministratorClients();
            form.Show();
        }

        private void acceptBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string name = nameTb.Text;
                string surname = surnameTb.Text;
                string? partonymic = partonymicTb.Text;
                long inp = long.Parse(inpTb.Text);
                string passportNumber = passportNumberTb.Text;
                string phoneNumber = phoneNumberTb.Text;
                Sex sex = (Sex)sexCb.SelectedIndex;
                DateTime dateBirth = dateBirthDtp.Value;
                string adress = adressTb.Text;
                string password = passwordTb.Text;

                if (sexCb.SelectedIndex == -1 || sexCb.SelectedIndex == -1)
                {
                    throw new FormatException("Перевірте правильність заповнення поля Стать!");
                }

                if (acceptBtn.Text == "  Відредагувати")
                {
                    DataBase.Instance.Clients.Update(name, surname, inp, passportNumber, phoneNumber, adress, password);
                    MessageBox.Show("Клієнта відредаговано!", "Повідомлення", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if (DataBase.Instance.Clients.Add(name, surname, partonymic, inp, passportNumber, phoneNumber, sex, dateBirth, adress, password))
                        MessageBox.Show("Клієнта додано!", "Повідомлення", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        throw new Exception("Такий користувач вже існує. Перевірте дані!");
                }

                Hide();
                AdministratorClients form = new AdministratorClients();
                form.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Повідомлення", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                long inp = long.Parse(inpTb.Text);
                DialogResult result = MessageBox.Show("Ви впевнені, що хочете видалити клієнта?", "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    if (DataBase.Instance.Clients.Remove(inp))
                    {
                        MessageBox.Show("Клієнта видалено!", "Повідомлення", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Hide();
                        AdministratorClients form = new AdministratorClients();
                        form.Show();
                    }
                    else
                    {
                        MessageBox.Show("Неможливо видалити клієнта з відкритим хоча б одним депозитом!", "Повідомлення", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Повідомлення", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void AdministratorAddEditClient_FormClosing(object sender, FormClosingEventArgs e)
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
