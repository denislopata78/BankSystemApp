namespace BankSystemApp
{
    partial class ClientDepositControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.withdrawBtn = new System.Windows.Forms.Button();
            this.nameValue = new System.Windows.Forms.Label();
            this.depositType = new System.Windows.Forms.Label();
            this.openDate = new System.Windows.Forms.Label();
            this.endDate = new System.Windows.Forms.Label();
            this.interest = new System.Windows.Forms.Label();
            this.paymentPerMonth = new System.Windows.Forms.Label();
            this.paymentPerMonthValue = new System.Windows.Forms.Label();
            this.interestValue = new System.Windows.Forms.Label();
            this.endDateValue = new System.Windows.Forms.Label();
            this.openDateValue = new System.Windows.Forms.Label();
            this.depositTypeValue = new System.Windows.Forms.Label();
            this.amountValue = new System.Windows.Forms.Label();
            this.profitValue = new System.Windows.Forms.Label();
            this.depositPb = new System.Windows.Forms.PictureBox();
            this.closeBtn = new System.Windows.Forms.Button();
            this.depositProgramValue = new System.Windows.Forms.Label();
            this.depositProgram = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.depositPb)).BeginInit();
            this.SuspendLayout();
            // 
            // withdrawBtn
            // 
            this.withdrawBtn.BackColor = System.Drawing.Color.White;
            this.withdrawBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.withdrawBtn.FlatAppearance.BorderSize = 0;
            this.withdrawBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.withdrawBtn.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.withdrawBtn.Location = new System.Drawing.Point(372, 55);
            this.withdrawBtn.Name = "withdrawBtn";
            this.withdrawBtn.Size = new System.Drawing.Size(160, 32);
            this.withdrawBtn.TabIndex = 0;
            this.withdrawBtn.Text = "Зняти кошти";
            this.withdrawBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.withdrawBtn.UseVisualStyleBackColor = false;
            this.withdrawBtn.Click += new System.EventHandler(this.withdrawBtn_Click);
            // 
            // nameValue
            // 
            this.nameValue.AutoSize = true;
            this.nameValue.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.nameValue.Location = new System.Drawing.Point(44, 16);
            this.nameValue.Name = "nameValue";
            this.nameValue.Size = new System.Drawing.Size(96, 22);
            this.nameValue.TabIndex = 2;
            this.nameValue.Text = "Депозит";
            // 
            // depositType
            // 
            this.depositType.AutoSize = true;
            this.depositType.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.depositType.Location = new System.Drawing.Point(17, 71);
            this.depositType.Name = "depositType";
            this.depositType.Size = new System.Drawing.Size(35, 18);
            this.depositType.TabIndex = 3;
            this.depositType.Text = "Тип";
            // 
            // openDate
            // 
            this.openDate.AutoSize = true;
            this.openDate.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.openDate.Location = new System.Drawing.Point(17, 93);
            this.openDate.Name = "openDate";
            this.openDate.Size = new System.Drawing.Size(120, 18);
            this.openDate.TabIndex = 4;
            this.openDate.Text = "Дата відкриття";
            // 
            // endDate
            // 
            this.endDate.AutoSize = true;
            this.endDate.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.endDate.Location = new System.Drawing.Point(17, 117);
            this.endDate.Name = "endDate";
            this.endDate.Size = new System.Drawing.Size(132, 18);
            this.endDate.TabIndex = 5;
            this.endDate.Text = "Дата закінчення";
            // 
            // interest
            // 
            this.interest.AutoSize = true;
            this.interest.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.interest.Location = new System.Drawing.Point(17, 142);
            this.interest.Name = "interest";
            this.interest.Size = new System.Drawing.Size(77, 18);
            this.interest.TabIndex = 6;
            this.interest.Text = "% річних";
            // 
            // paymentPerMonth
            // 
            this.paymentPerMonth.AutoSize = true;
            this.paymentPerMonth.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.paymentPerMonth.Location = new System.Drawing.Point(17, 165);
            this.paymentPerMonth.Name = "paymentPerMonth";
            this.paymentPerMonth.Size = new System.Drawing.Size(155, 18);
            this.paymentPerMonth.TabIndex = 7;
            this.paymentPerMonth.Text = "Щомісячних платіж";
            // 
            // paymentPerMonthValue
            // 
            this.paymentPerMonthValue.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.paymentPerMonthValue.Location = new System.Drawing.Point(222, 163);
            this.paymentPerMonthValue.Name = "paymentPerMonthValue";
            this.paymentPerMonthValue.Size = new System.Drawing.Size(121, 20);
            this.paymentPerMonthValue.TabIndex = 12;
            this.paymentPerMonthValue.Text = "35 UAH";
            this.paymentPerMonthValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // interestValue
            // 
            this.interestValue.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.interestValue.Location = new System.Drawing.Point(242, 140);
            this.interestValue.Name = "interestValue";
            this.interestValue.Size = new System.Drawing.Size(101, 20);
            this.interestValue.TabIndex = 11;
            this.interestValue.Text = "5 %";
            this.interestValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // endDateValue
            // 
            this.endDateValue.AutoSize = true;
            this.endDateValue.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.endDateValue.Location = new System.Drawing.Point(245, 117);
            this.endDateValue.Name = "endDateValue";
            this.endDateValue.Size = new System.Drawing.Size(98, 18);
            this.endDateValue.TabIndex = 10;
            this.endDateValue.Text = "10.02.2023";
            // 
            // openDateValue
            // 
            this.openDateValue.AutoSize = true;
            this.openDateValue.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.openDateValue.Location = new System.Drawing.Point(245, 93);
            this.openDateValue.Name = "openDateValue";
            this.openDateValue.Size = new System.Drawing.Size(98, 18);
            this.openDateValue.TabIndex = 9;
            this.openDateValue.Text = "10.02.2023";
            // 
            // depositTypeValue
            // 
            this.depositTypeValue.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.depositTypeValue.Location = new System.Drawing.Point(200, 69);
            this.depositTypeValue.Name = "depositTypeValue";
            this.depositTypeValue.Size = new System.Drawing.Size(143, 20);
            this.depositTypeValue.TabIndex = 8;
            this.depositTypeValue.Text = "Строковий";
            this.depositTypeValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // amountValue
            // 
            this.amountValue.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.amountValue.Location = new System.Drawing.Point(349, 152);
            this.amountValue.Name = "amountValue";
            this.amountValue.Size = new System.Drawing.Size(183, 22);
            this.amountValue.TabIndex = 13;
            this.amountValue.Text = "5000 UAH";
            this.amountValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // profitValue
            // 
            this.profitValue.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.profitValue.Location = new System.Drawing.Point(369, 131);
            this.profitValue.Name = "profitValue";
            this.profitValue.Size = new System.Drawing.Size(163, 18);
            this.profitValue.TabIndex = 14;
            this.profitValue.Text = "+ 250 UAH";
            this.profitValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // depositPb
            // 
            this.depositPb.Image = global::BankSystemApp.Properties.Resources.Wallet20Icon;
            this.depositPb.Location = new System.Drawing.Point(17, 15);
            this.depositPb.Name = "depositPb";
            this.depositPb.Size = new System.Drawing.Size(20, 20);
            this.depositPb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.depositPb.TabIndex = 15;
            this.depositPb.TabStop = false;
            // 
            // closeBtn
            // 
            this.closeBtn.BackColor = System.Drawing.Color.White;
            this.closeBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.closeBtn.FlatAppearance.BorderSize = 0;
            this.closeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeBtn.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.closeBtn.Location = new System.Drawing.Point(372, 90);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(160, 32);
            this.closeBtn.TabIndex = 16;
            this.closeBtn.Text = "Закрити";
            this.closeBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.closeBtn.UseVisualStyleBackColor = false;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // depositProgramValue
            // 
            this.depositProgramValue.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.depositProgramValue.Location = new System.Drawing.Point(189, 47);
            this.depositProgramValue.Name = "depositProgramValue";
            this.depositProgramValue.Size = new System.Drawing.Size(154, 20);
            this.depositProgramValue.TabIndex = 18;
            this.depositProgramValue.Text = "Програма";
            this.depositProgramValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // depositProgram
            // 
            this.depositProgram.AutoSize = true;
            this.depositProgram.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.depositProgram.Location = new System.Drawing.Point(17, 49);
            this.depositProgram.Name = "depositProgram";
            this.depositProgram.Size = new System.Drawing.Size(166, 18);
            this.depositProgram.TabIndex = 17;
            this.depositProgram.Text = "Депозитна програма";
            // 
            // ClientDepositControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(244)))));
            this.Controls.Add(this.depositProgramValue);
            this.Controls.Add(this.depositProgram);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.depositPb);
            this.Controls.Add(this.profitValue);
            this.Controls.Add(this.amountValue);
            this.Controls.Add(this.paymentPerMonthValue);
            this.Controls.Add(this.interestValue);
            this.Controls.Add(this.endDateValue);
            this.Controls.Add(this.openDateValue);
            this.Controls.Add(this.depositTypeValue);
            this.Controls.Add(this.paymentPerMonth);
            this.Controls.Add(this.interest);
            this.Controls.Add(this.endDate);
            this.Controls.Add(this.openDate);
            this.Controls.Add(this.depositType);
            this.Controls.Add(this.nameValue);
            this.Controls.Add(this.withdrawBtn);
            this.Name = "ClientDepositControl";
            this.Size = new System.Drawing.Size(540, 200);
            ((System.ComponentModel.ISupportInitialize)(this.depositPb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button withdrawBtn;
        private Label nameValue;
        private Label depositType;
        private Label openDate;
        private Label endDate;
        private Label interest;
        private Label paymentPerMonth;
        private Label paymentPerMonthValue;
        private Label interestValue;
        private Label endDateValue;
        private Label openDateValue;
        private Label depositTypeValue;
        private Label amountValue;
        private Label profitValue;
        private PictureBox depositPb;
        private Button closeBtn;
        private Label depositProgramValue;
        private Label depositProgram;
    }
}
