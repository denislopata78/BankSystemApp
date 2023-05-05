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
    public partial class DepositProgramControl : UserControl
    {
        public DepositProgram DepositProgram { get; set; }
        public DepositProgramControl(DepositProgram depositProgram)
        {
            InitializeComponent();

            DepositProgram = depositProgram;
            title.Text = DepositProgram.Name;
            currencyTypeValue.Text = DepositProgram.CurrencyType.ToString();
            if (DepositProgram.Type == TypeDeposit.DemandDeposit)
                typeValue.Text = "До запитання";
            else
                typeValue.Text = "Строковий";
            percentMonth3.Text = $"{DepositProgram.InterestRates.FirstOrDefault(x => x.Key == 3).Value * 100} %";
            percentMonth6.Text = $"{DepositProgram.InterestRates.FirstOrDefault(x => x.Key == 6).Value * 100} %";
            percentMonth9.Text = $"{DepositProgram.InterestRates.FirstOrDefault(x => x.Key == 9).Value * 100} %";
            percentMonth12.Text = $"{DepositProgram.InterestRates.FirstOrDefault(x => x.Key == 12).Value * 100} %";
        }

        private void editPb_Click(object sender, EventArgs e)
        {
            Form currentForm = this.FindForm();
            currentForm.Hide();
            AdministratorAddEditDepositProgram form = new AdministratorAddEditDepositProgram(DepositProgram);
            form.ShowDialog();
        }
    }
}
