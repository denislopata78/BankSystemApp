namespace BankSystemApp
{
    partial class AdministratorAddEditClient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdministratorAddEditClient));
            this.depositsClientPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.back = new System.Windows.Forms.PictureBox();
            this.user = new System.Windows.Forms.Label();
            this.acceptBtn = new System.Windows.Forms.Button();
            this.description = new System.Windows.Forms.Label();
            this.userPb = new System.Windows.Forms.PictureBox();
            this.title = new System.Windows.Forms.Label();
            this.info1Pb = new System.Windows.Forms.PictureBox();
            this.info1 = new System.Windows.Forms.Label();
            this.info2Pb = new System.Windows.Forms.PictureBox();
            this.info2 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.surname = new System.Windows.Forms.Label();
            this.partonymic = new System.Windows.Forms.Label();
            this.inp = new System.Windows.Forms.Label();
            this.passportNumber = new System.Windows.Forms.Label();
            this.phoneNumber = new System.Windows.Forms.Label();
            this.sex = new System.Windows.Forms.Label();
            this.dateBirth = new System.Windows.Forms.Label();
            this.adress = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.Label();
            this.nameTb = new System.Windows.Forms.TextBox();
            this.surnameTb = new System.Windows.Forms.TextBox();
            this.partonymicTb = new System.Windows.Forms.TextBox();
            this.phoneNumberTb = new System.Windows.Forms.TextBox();
            this.passportNumberTb = new System.Windows.Forms.TextBox();
            this.inpTb = new System.Windows.Forms.TextBox();
            this.adressTb = new System.Windows.Forms.TextBox();
            this.passwordTb = new System.Windows.Forms.TextBox();
            this.sexCb = new System.Windows.Forms.ComboBox();
            this.dateBirthDtp = new System.Windows.Forms.DateTimePicker();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.back)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userPb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.info1Pb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.info2Pb)).BeginInit();
            this.SuspendLayout();
            // 
            // depositsClientPanel
            // 
            this.depositsClientPanel.AutoScroll = true;
            this.depositsClientPanel.Location = new System.Drawing.Point(595, 106);
            this.depositsClientPanel.Name = "depositsClientPanel";
            this.depositsClientPanel.Size = new System.Drawing.Size(275, 285);
            this.depositsClientPanel.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(225)))), ((int)(((byte)(233)))));
            this.panel1.Controls.Add(this.back);
            this.panel1.Controls.Add(this.user);
            this.panel1.Controls.Add(this.acceptBtn);
            this.panel1.Controls.Add(this.description);
            this.panel1.Controls.Add(this.userPb);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(235, 453);
            this.panel1.TabIndex = 2;
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
            this.user.AutoSize = true;
            this.user.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.user.Location = new System.Drawing.Point(73, 32);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(139, 22);
            this.user.TabIndex = 3;
            this.user.Text = "Адміністратор";
            // 
            // acceptBtn
            // 
            this.acceptBtn.BackColor = System.Drawing.Color.White;
            this.acceptBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.acceptBtn.FlatAppearance.BorderSize = 0;
            this.acceptBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.acceptBtn.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.acceptBtn.Location = new System.Drawing.Point(17, 128);
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
            this.description.Location = new System.Drawing.Point(17, 193);
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(174, 48);
            this.description.TabIndex = 1;
            this.description.Text = "* Перед підтверженням \r\nперевірте коректність \r\nвведененних даних";
            // 
            // userPb
            // 
            this.userPb.Image = global::BankSystemApp.Properties.Resources.UserIcon;
            this.userPb.Location = new System.Drawing.Point(22, 23);
            this.userPb.Name = "userPb";
            this.userPb.Size = new System.Drawing.Size(40, 40);
            this.userPb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.userPb.TabIndex = 0;
            this.userPb.TabStop = false;
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.title.Location = new System.Drawing.Point(640, 22);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(215, 34);
            this.title.TabIndex = 6;
            this.title.Text = "BankDeposit";
            // 
            // info1Pb
            // 
            this.info1Pb.Image = global::BankSystemApp.Properties.Resources.InfoIcon;
            this.info1Pb.Location = new System.Drawing.Point(254, 18);
            this.info1Pb.Name = "info1Pb";
            this.info1Pb.Size = new System.Drawing.Size(38, 38);
            this.info1Pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.info1Pb.TabIndex = 5;
            this.info1Pb.TabStop = false;
            // 
            // info1
            // 
            this.info1.AutoSize = true;
            this.info1.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.info1.Location = new System.Drawing.Point(298, 27);
            this.info1.Name = "info1";
            this.info1.Size = new System.Drawing.Size(217, 22);
            this.info1.TabIndex = 4;
            this.info1.Text = "Контактна інформація";
            // 
            // info2Pb
            // 
            this.info2Pb.Image = global::BankSystemApp.Properties.Resources.CardIcon;
            this.info2Pb.Location = new System.Drawing.Point(595, 62);
            this.info2Pb.Name = "info2Pb";
            this.info2Pb.Size = new System.Drawing.Size(30, 30);
            this.info2Pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.info2Pb.TabIndex = 8;
            this.info2Pb.TabStop = false;
            // 
            // info2
            // 
            this.info2.AutoSize = true;
            this.info2.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.info2.Location = new System.Drawing.Point(631, 70);
            this.info2.Name = "info2";
            this.info2.Size = new System.Drawing.Size(178, 22);
            this.info2.TabIndex = 7;
            this.info2.Text = "Відкриті депозити";
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.name.Location = new System.Drawing.Point(253, 106);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(36, 18);
            this.name.TabIndex = 9;
            this.name.Text = "Ім\'я";
            // 
            // surname
            // 
            this.surname.AutoSize = true;
            this.surname.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.surname.Location = new System.Drawing.Point(253, 74);
            this.surname.Name = "surname";
            this.surname.Size = new System.Drawing.Size(80, 18);
            this.surname.TabIndex = 10;
            this.surname.Text = "Прізвище";
            // 
            // partonymic
            // 
            this.partonymic.AutoSize = true;
            this.partonymic.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.partonymic.Location = new System.Drawing.Point(253, 138);
            this.partonymic.Name = "partonymic";
            this.partonymic.Size = new System.Drawing.Size(101, 18);
            this.partonymic.TabIndex = 11;
            this.partonymic.Text = "По-батькові";
            // 
            // inp
            // 
            this.inp.AutoSize = true;
            this.inp.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.inp.Location = new System.Drawing.Point(253, 170);
            this.inp.Name = "inp";
            this.inp.Size = new System.Drawing.Size(35, 18);
            this.inp.TabIndex = 12;
            this.inp.Text = "ІНП";
            // 
            // passportNumber
            // 
            this.passportNumber.AutoSize = true;
            this.passportNumber.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.passportNumber.Location = new System.Drawing.Point(253, 202);
            this.passportNumber.Name = "passportNumber";
            this.passportNumber.Size = new System.Drawing.Size(101, 18);
            this.passportNumber.TabIndex = 13;
            this.passportNumber.Text = "№ паспорту";
            // 
            // phoneNumber
            // 
            this.phoneNumber.AutoSize = true;
            this.phoneNumber.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.phoneNumber.Location = new System.Drawing.Point(253, 234);
            this.phoneNumber.Name = "phoneNumber";
            this.phoneNumber.Size = new System.Drawing.Size(76, 18);
            this.phoneNumber.TabIndex = 14;
            this.phoneNumber.Text = "Телефон";
            // 
            // sex
            // 
            this.sex.AutoSize = true;
            this.sex.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sex.Location = new System.Drawing.Point(253, 266);
            this.sex.Name = "sex";
            this.sex.Size = new System.Drawing.Size(51, 18);
            this.sex.TabIndex = 15;
            this.sex.Text = "Стать";
            // 
            // dateBirth
            // 
            this.dateBirth.AutoSize = true;
            this.dateBirth.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateBirth.Location = new System.Drawing.Point(253, 295);
            this.dateBirth.Name = "dateBirth";
            this.dateBirth.Size = new System.Drawing.Size(103, 36);
            this.dateBirth.TabIndex = 16;
            this.dateBirth.Text = "Дата \r\nнародження";
            // 
            // adress
            // 
            this.adress.AutoSize = true;
            this.adress.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.adress.Location = new System.Drawing.Point(253, 369);
            this.adress.Name = "adress";
            this.adress.Size = new System.Drawing.Size(62, 18);
            this.adress.TabIndex = 17;
            this.adress.Text = "Адреса";
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.password.Location = new System.Drawing.Point(253, 409);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(65, 18);
            this.password.TabIndex = 18;
            this.password.Text = "Пароль";
            // 
            // nameTb
            // 
            this.nameTb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(244)))));
            this.nameTb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nameTb.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nameTb.Location = new System.Drawing.Point(439, 98);
            this.nameTb.Multiline = true;
            this.nameTb.Name = "nameTb";
            this.nameTb.Size = new System.Drawing.Size(145, 26);
            this.nameTb.TabIndex = 19;
            // 
            // surnameTb
            // 
            this.surnameTb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(244)))));
            this.surnameTb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.surnameTb.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.surnameTb.Location = new System.Drawing.Point(439, 66);
            this.surnameTb.Multiline = true;
            this.surnameTb.Name = "surnameTb";
            this.surnameTb.Size = new System.Drawing.Size(145, 26);
            this.surnameTb.TabIndex = 20;
            // 
            // partonymicTb
            // 
            this.partonymicTb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(244)))));
            this.partonymicTb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.partonymicTb.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.partonymicTb.Location = new System.Drawing.Point(439, 130);
            this.partonymicTb.Multiline = true;
            this.partonymicTb.Name = "partonymicTb";
            this.partonymicTb.Size = new System.Drawing.Size(145, 26);
            this.partonymicTb.TabIndex = 21;
            // 
            // phoneNumberTb
            // 
            this.phoneNumberTb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(244)))));
            this.phoneNumberTb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.phoneNumberTb.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.phoneNumberTb.Location = new System.Drawing.Point(439, 226);
            this.phoneNumberTb.Multiline = true;
            this.phoneNumberTb.Name = "phoneNumberTb";
            this.phoneNumberTb.Size = new System.Drawing.Size(145, 26);
            this.phoneNumberTb.TabIndex = 22;
            // 
            // passportNumberTb
            // 
            this.passportNumberTb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(244)))));
            this.passportNumberTb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passportNumberTb.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.passportNumberTb.Location = new System.Drawing.Point(439, 194);
            this.passportNumberTb.Multiline = true;
            this.passportNumberTb.Name = "passportNumberTb";
            this.passportNumberTb.Size = new System.Drawing.Size(145, 26);
            this.passportNumberTb.TabIndex = 23;
            // 
            // inpTb
            // 
            this.inpTb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(244)))));
            this.inpTb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.inpTb.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.inpTb.Location = new System.Drawing.Point(439, 162);
            this.inpTb.Multiline = true;
            this.inpTb.Name = "inpTb";
            this.inpTb.Size = new System.Drawing.Size(145, 26);
            this.inpTb.TabIndex = 24;
            // 
            // adressTb
            // 
            this.adressTb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(244)))));
            this.adressTb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.adressTb.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.adressTb.Location = new System.Drawing.Point(439, 342);
            this.adressTb.Multiline = true;
            this.adressTb.Name = "adressTb";
            this.adressTb.Size = new System.Drawing.Size(145, 49);
            this.adressTb.TabIndex = 27;
            // 
            // passwordTb
            // 
            this.passwordTb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(244)))));
            this.passwordTb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passwordTb.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.passwordTb.Location = new System.Drawing.Point(439, 402);
            this.passwordTb.Multiline = true;
            this.passwordTb.Name = "passwordTb";
            this.passwordTb.Size = new System.Drawing.Size(145, 26);
            this.passwordTb.TabIndex = 28;
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
            this.sexCb.Location = new System.Drawing.Point(439, 256);
            this.sexCb.Name = "sexCb";
            this.sexCb.Size = new System.Drawing.Size(145, 26);
            this.sexCb.TabIndex = 29;
            // 
            // dateBirthDtp
            // 
            this.dateBirthDtp.CalendarFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateBirthDtp.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateBirthDtp.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateBirthDtp.Location = new System.Drawing.Point(439, 304);
            this.dateBirthDtp.Name = "dateBirthDtp";
            this.dateBirthDtp.Size = new System.Drawing.Size(145, 26);
            this.dateBirthDtp.TabIndex = 30;
            // 
            // deleteBtn
            // 
            this.deleteBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            this.deleteBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.deleteBtn.FlatAppearance.BorderSize = 0;
            this.deleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteBtn.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.deleteBtn.ForeColor = System.Drawing.Color.White;
            this.deleteBtn.Location = new System.Drawing.Point(595, 397);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(275, 31);
            this.deleteBtn.TabIndex = 21;
            this.deleteBtn.Text = "Видалити ";
            this.deleteBtn.UseVisualStyleBackColor = false;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // AdministratorAddEditClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(882, 453);
            this.Controls.Add(this.deleteBtn);
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
            this.Controls.Add(this.inp);
            this.Controls.Add(this.partonymic);
            this.Controls.Add(this.surname);
            this.Controls.Add(this.name);
            this.Controls.Add(this.info2Pb);
            this.Controls.Add(this.info2);
            this.Controls.Add(this.title);
            this.Controls.Add(this.info1Pb);
            this.Controls.Add(this.info1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.depositsClientPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AdministratorAddEditClient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bank System - Client";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AdministratorAddEditClient_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.back)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userPb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.info1Pb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.info2Pb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FlowLayoutPanel depositsClientPanel;
        private Panel panel1;
        private PictureBox back;
        private Label user;
        private Button acceptBtn;
        private Label description;
        private PictureBox userPb;
        private Label title;
        private PictureBox info1Pb;
        private Label info1;
        private PictureBox info2Pb;
        private Label info2;
        private Label name;
        private Label surname;
        private Label partonymic;
        private Label inp;
        private Label passportNumber;
        private Label phoneNumber;
        private Label sex;
        private Label dateBirth;
        private Label adress;
        private Label password;
        private TextBox nameTb;
        private TextBox surnameTb;
        private TextBox partonymicTb;
        private TextBox phoneNumberTb;
        private TextBox passportNumberTb;
        private TextBox inpTb;
        private TextBox adressTb;
        private TextBox passwordTb;
        private ComboBox sexCb;
        private DateTimePicker dateBirthDtp;
        private Button deleteBtn;
    }
}