namespace BankSystemApp
{
    partial class ClientInfo
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientInfo));
            this.dateBirthDtp = new System.Windows.Forms.DateTimePicker();
            this.sexCb = new System.Windows.Forms.ComboBox();
            this.inpTb = new System.Windows.Forms.TextBox();
            this.passwordTb = new System.Windows.Forms.TextBox();
            this.adressTb = new System.Windows.Forms.TextBox();
            this.passportNumberTb = new System.Windows.Forms.TextBox();
            this.phoneNumberTb = new System.Windows.Forms.TextBox();
            this.partonymicTb = new System.Windows.Forms.TextBox();
            this.surnameTb = new System.Windows.Forms.TextBox();
            this.nameTb = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.Label();
            this.adress = new System.Windows.Forms.Label();
            this.dateBirth = new System.Windows.Forms.Label();
            this.sex = new System.Windows.Forms.Label();
            this.phoneNumber = new System.Windows.Forms.Label();
            this.passportNumber = new System.Windows.Forms.Label();
            this.partonymic = new System.Windows.Forms.Label();
            this.surname = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.hidePb = new System.Windows.Forms.PictureBox();
            this.title = new System.Windows.Forms.Label();
            this.info1Pb = new System.Windows.Forms.PictureBox();
            this.info1 = new System.Windows.Forms.Label();
            this.inp = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.amountUSD = new System.Windows.Forms.Label();
            this.amountEUR = new System.Windows.Forms.Label();
            this.amountUAH = new System.Windows.Forms.Label();
            this.back = new System.Windows.Forms.PictureBox();
            this.user = new System.Windows.Forms.Label();
            this.acceptBtn = new System.Windows.Forms.Button();
            this.description = new System.Windows.Forms.Label();
            this.userPb = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.hidePb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.info1Pb)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.back)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userPb)).BeginInit();
            this.SuspendLayout();
            // 
            // dateBirthDtp
            // 
            this.dateBirthDtp.CalendarFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateBirthDtp.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateBirthDtp.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateBirthDtp.Location = new System.Drawing.Point(445, 334);
            this.dateBirthDtp.Name = "dateBirthDtp";
            this.dateBirthDtp.Size = new System.Drawing.Size(145, 26);
            this.dateBirthDtp.TabIndex = 58;
            // 
            // sexCb
            // 
            this.sexCb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(244)))));
            this.sexCb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sexCb.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sexCb.FormattingEnabled = true;
            this.sexCb.Items.AddRange(new object[] {
            "чоловік",
            "жінка"});
            this.sexCb.Location = new System.Drawing.Point(445, 282);
            this.sexCb.Name = "sexCb";
            this.sexCb.Size = new System.Drawing.Size(145, 26);
            this.sexCb.TabIndex = 57;
            // 
            // inpTb
            // 
            this.inpTb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(244)))));
            this.inpTb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.inpTb.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.inpTb.Location = new System.Drawing.Point(445, 176);
            this.inpTb.Multiline = true;
            this.inpTb.Name = "inpTb";
            this.inpTb.Size = new System.Drawing.Size(145, 26);
            this.inpTb.TabIndex = 54;
            // 
            // passwordTb
            // 
            this.passwordTb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(244)))));
            this.passwordTb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passwordTb.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.passwordTb.Location = new System.Drawing.Point(689, 400);
            this.passwordTb.Multiline = true;
            this.passwordTb.Name = "passwordTb";
            this.passwordTb.PasswordChar = '*';
            this.passwordTb.Size = new System.Drawing.Size(145, 26);
            this.passwordTb.TabIndex = 56;
            // 
            // adressTb
            // 
            this.adressTb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(244)))));
            this.adressTb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.adressTb.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.adressTb.Location = new System.Drawing.Point(445, 377);
            this.adressTb.Multiline = true;
            this.adressTb.Name = "adressTb";
            this.adressTb.Size = new System.Drawing.Size(145, 49);
            this.adressTb.TabIndex = 55;
            // 
            // passportNumberTb
            // 
            this.passportNumberTb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(244)))));
            this.passportNumberTb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passportNumberTb.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.passportNumberTb.Location = new System.Drawing.Point(445, 212);
            this.passportNumberTb.Multiline = true;
            this.passportNumberTb.Name = "passportNumberTb";
            this.passportNumberTb.Size = new System.Drawing.Size(145, 26);
            this.passportNumberTb.TabIndex = 53;
            // 
            // phoneNumberTb
            // 
            this.phoneNumberTb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(244)))));
            this.phoneNumberTb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.phoneNumberTb.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.phoneNumberTb.Location = new System.Drawing.Point(445, 248);
            this.phoneNumberTb.Multiline = true;
            this.phoneNumberTb.Name = "phoneNumberTb";
            this.phoneNumberTb.Size = new System.Drawing.Size(145, 26);
            this.phoneNumberTb.TabIndex = 52;
            // 
            // partonymicTb
            // 
            this.partonymicTb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(244)))));
            this.partonymicTb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.partonymicTb.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.partonymicTb.Location = new System.Drawing.Point(445, 140);
            this.partonymicTb.Multiline = true;
            this.partonymicTb.Name = "partonymicTb";
            this.partonymicTb.Size = new System.Drawing.Size(145, 26);
            this.partonymicTb.TabIndex = 50;
            // 
            // surnameTb
            // 
            this.surnameTb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(244)))));
            this.surnameTb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.surnameTb.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.surnameTb.Location = new System.Drawing.Point(445, 69);
            this.surnameTb.Multiline = true;
            this.surnameTb.Name = "surnameTb";
            this.surnameTb.Size = new System.Drawing.Size(145, 26);
            this.surnameTb.TabIndex = 49;
            // 
            // nameTb
            // 
            this.nameTb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(244)))));
            this.nameTb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nameTb.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nameTb.Location = new System.Drawing.Point(445, 103);
            this.nameTb.Multiline = true;
            this.nameTb.Name = "nameTb";
            this.nameTb.Size = new System.Drawing.Size(145, 26);
            this.nameTb.TabIndex = 48;
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.password.Location = new System.Drawing.Point(601, 404);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(65, 18);
            this.password.TabIndex = 47;
            this.password.Text = "Пароль";
            // 
            // adress
            // 
            this.adress.AutoSize = true;
            this.adress.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.adress.Location = new System.Drawing.Point(259, 404);
            this.adress.Name = "adress";
            this.adress.Size = new System.Drawing.Size(62, 18);
            this.adress.TabIndex = 46;
            this.adress.Text = "Адреса";
            // 
            // dateBirth
            // 
            this.dateBirth.AutoSize = true;
            this.dateBirth.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateBirth.Location = new System.Drawing.Point(259, 325);
            this.dateBirth.Name = "dateBirth";
            this.dateBirth.Size = new System.Drawing.Size(103, 36);
            this.dateBirth.TabIndex = 45;
            this.dateBirth.Text = "Дата \r\nнародження";
            // 
            // sex
            // 
            this.sex.AutoSize = true;
            this.sex.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sex.Location = new System.Drawing.Point(259, 292);
            this.sex.Name = "sex";
            this.sex.Size = new System.Drawing.Size(51, 18);
            this.sex.TabIndex = 44;
            this.sex.Text = "Стать";
            // 
            // phoneNumber
            // 
            this.phoneNumber.AutoSize = true;
            this.phoneNumber.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.phoneNumber.Location = new System.Drawing.Point(259, 256);
            this.phoneNumber.Name = "phoneNumber";
            this.phoneNumber.Size = new System.Drawing.Size(76, 18);
            this.phoneNumber.TabIndex = 43;
            this.phoneNumber.Text = "Телефон";
            // 
            // passportNumber
            // 
            this.passportNumber.AutoSize = true;
            this.passportNumber.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.passportNumber.Location = new System.Drawing.Point(259, 220);
            this.passportNumber.Name = "passportNumber";
            this.passportNumber.Size = new System.Drawing.Size(101, 18);
            this.passportNumber.TabIndex = 42;
            this.passportNumber.Text = "№ паспорту";
            // 
            // partonymic
            // 
            this.partonymic.AutoSize = true;
            this.partonymic.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.partonymic.Location = new System.Drawing.Point(259, 148);
            this.partonymic.Name = "partonymic";
            this.partonymic.Size = new System.Drawing.Size(101, 18);
            this.partonymic.TabIndex = 40;
            this.partonymic.Text = "По-батькові";
            // 
            // surname
            // 
            this.surname.AutoSize = true;
            this.surname.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.surname.Location = new System.Drawing.Point(259, 77);
            this.surname.Name = "surname";
            this.surname.Size = new System.Drawing.Size(80, 18);
            this.surname.TabIndex = 39;
            this.surname.Text = "Прізвище";
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.name.Location = new System.Drawing.Point(259, 111);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(36, 18);
            this.name.TabIndex = 38;
            this.name.Text = "Ім\'я";
            // 
            // hidePb
            // 
            this.hidePb.Image = global::BankSystemApp.Properties.Resources.HideIcon;
            this.hidePb.Location = new System.Drawing.Point(845, 401);
            this.hidePb.Name = "hidePb";
            this.hidePb.Size = new System.Drawing.Size(21, 21);
            this.hidePb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.hidePb.TabIndex = 37;
            this.hidePb.TabStop = false;
            this.hidePb.Click += new System.EventHandler(this.hidePb_Click);
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.title.Location = new System.Drawing.Point(646, 22);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(215, 34);
            this.title.TabIndex = 35;
            this.title.Text = "BankDeposit";
            // 
            // info1Pb
            // 
            this.info1Pb.Image = global::BankSystemApp.Properties.Resources.InfoIcon;
            this.info1Pb.Location = new System.Drawing.Point(260, 18);
            this.info1Pb.Name = "info1Pb";
            this.info1Pb.Size = new System.Drawing.Size(38, 38);
            this.info1Pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.info1Pb.TabIndex = 34;
            this.info1Pb.TabStop = false;
            // 
            // info1
            // 
            this.info1.AutoSize = true;
            this.info1.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.info1.Location = new System.Drawing.Point(304, 27);
            this.info1.Name = "info1";
            this.info1.Size = new System.Drawing.Size(217, 22);
            this.info1.TabIndex = 33;
            this.info1.Text = "Контактна інформація";
            // 
            // inp
            // 
            this.inp.AutoSize = true;
            this.inp.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.inp.Location = new System.Drawing.Point(259, 184);
            this.inp.Name = "inp";
            this.inp.Size = new System.Drawing.Size(35, 18);
            this.inp.TabIndex = 41;
            this.inp.Text = "ІНП";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(225)))), ((int)(((byte)(233)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.amountUSD);
            this.panel1.Controls.Add(this.amountEUR);
            this.panel1.Controls.Add(this.amountUAH);
            this.panel1.Controls.Add(this.back);
            this.panel1.Controls.Add(this.user);
            this.panel1.Controls.Add(this.acceptBtn);
            this.panel1.Controls.Add(this.description);
            this.panel1.Controls.Add(this.userPb);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(235, 453);
            this.panel1.TabIndex = 59;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(19, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 20);
            this.label1.TabIndex = 23;
            this.label1.Text = "Баланс";
            // 
            // amountUSD
            // 
            this.amountUSD.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.amountUSD.Location = new System.Drawing.Point(100, 116);
            this.amountUSD.Name = "amountUSD";
            this.amountUSD.Size = new System.Drawing.Size(129, 18);
            this.amountUSD.TabIndex = 21;
            this.amountUSD.Text = "100000 EUR";
            this.amountUSD.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // amountEUR
            // 
            this.amountEUR.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.amountEUR.Location = new System.Drawing.Point(103, 95);
            this.amountEUR.Name = "amountEUR";
            this.amountEUR.Size = new System.Drawing.Size(126, 20);
            this.amountEUR.TabIndex = 19;
            this.amountEUR.Text = "100000 USD";
            this.amountEUR.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // amountUAH
            // 
            this.amountUAH.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.amountUAH.Location = new System.Drawing.Point(103, 75);
            this.amountUAH.Name = "amountUAH";
            this.amountUAH.Size = new System.Drawing.Size(126, 20);
            this.amountUAH.TabIndex = 17;
            this.amountUAH.Text = "1000000 UAH";
            this.amountUAH.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // back
            // 
            this.back.Image = global::BankSystemApp.Properties.Resources.BackIcon;
            this.back.Location = new System.Drawing.Point(12, 411);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(30, 30);
            this.back.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.back.TabIndex = 8;
            this.back.TabStop = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // user
            // 
            this.user.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.user.Location = new System.Drawing.Point(70, 31);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(159, 22);
            this.user.TabIndex = 3;
            this.user.Text = "Адміністратор";
            this.user.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // acceptBtn
            // 
            this.acceptBtn.BackColor = System.Drawing.Color.White;
            this.acceptBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.acceptBtn.FlatAppearance.BorderSize = 0;
            this.acceptBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.acceptBtn.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.acceptBtn.Location = new System.Drawing.Point(19, 160);
            this.acceptBtn.Name = "acceptBtn";
            this.acceptBtn.Size = new System.Drawing.Size(203, 44);
            this.acceptBtn.TabIndex = 2;
            this.acceptBtn.Text = "  Підтвердити";
            this.acceptBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.acceptBtn.UseVisualStyleBackColor = false;
            this.acceptBtn.Click += new System.EventHandler(this.acceptBtn_Click);
            // 
            // description
            // 
            this.description.AutoSize = true;
            this.description.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.description.Location = new System.Drawing.Point(19, 217);
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(174, 48);
            this.description.TabIndex = 1;
            this.description.Text = "* Перед підтверженням \r\nперевірте коректність \r\nвведененних даних";
            // 
            // userPb
            // 
            this.userPb.Image = global::BankSystemApp.Properties.Resources.UserIcon;
            this.userPb.Location = new System.Drawing.Point(19, 22);
            this.userPb.Name = "userPb";
            this.userPb.Size = new System.Drawing.Size(40, 40);
            this.userPb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.userPb.TabIndex = 0;
            this.userPb.TabStop = false;
            // 
            // ClientInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(882, 453);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dateBirthDtp);
            this.Controls.Add(this.sexCb);
            this.Controls.Add(this.inpTb);
            this.Controls.Add(this.passwordTb);
            this.Controls.Add(this.adressTb);
            this.Controls.Add(this.passportNumberTb);
            this.Controls.Add(this.phoneNumberTb);
            this.Controls.Add(this.partonymicTb);
            this.Controls.Add(this.surnameTb);
            this.Controls.Add(this.nameTb);
            this.Controls.Add(this.password);
            this.Controls.Add(this.adress);
            this.Controls.Add(this.dateBirth);
            this.Controls.Add(this.sex);
            this.Controls.Add(this.phoneNumber);
            this.Controls.Add(this.passportNumber);
            this.Controls.Add(this.partonymic);
            this.Controls.Add(this.surname);
            this.Controls.Add(this.name);
            this.Controls.Add(this.hidePb);
            this.Controls.Add(this.title);
            this.Controls.Add(this.info1Pb);
            this.Controls.Add(this.info1);
            this.Controls.Add(this.inp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ClientInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bank System - Client";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ClientInfo_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.hidePb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.info1Pb)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.back)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userPb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DateTimePicker dateBirthDtp;
        private ComboBox sexCb;
        private TextBox inpTb;
        private TextBox passwordTb;
        private TextBox adressTb;
        private TextBox passportNumberTb;
        private TextBox phoneNumberTb;
        private TextBox partonymicTb;
        private TextBox surnameTb;
        private TextBox nameTb;
        private Label password;
        private Label adress;
        private Label dateBirth;
        private Label sex;
        private Label phoneNumber;
        private Label passportNumber;
        private Label partonymic;
        private Label surname;
        private Label name;
        private PictureBox hidePb;
        private Label title;
        private PictureBox info1Pb;
        private Label info1;
        private Label inp;
        private Panel panel1;
        private Label label1;
        private Label amountUSD;
        private Label amountEUR;
        private Label amountUAH;
        private PictureBox back;
        private Label user;
        private Button acceptBtn;
        private Label description;
        private PictureBox userPb;
    }
}