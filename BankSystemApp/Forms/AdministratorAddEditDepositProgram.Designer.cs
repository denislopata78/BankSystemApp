namespace BankSystemApp
{
    partial class AdministratorAddEditDepositProgram
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdministratorAddEditDepositProgram));
            this.info = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.back = new System.Windows.Forms.PictureBox();
            this.user = new System.Windows.Forms.Label();
            this.acceptBtn = new System.Windows.Forms.Button();
            this.description = new System.Windows.Forms.Label();
            this.userPb = new System.Windows.Forms.PictureBox();
            this.infoPb = new System.Windows.Forms.PictureBox();
            this.title = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.type = new System.Windows.Forms.Label();
            this.currencyType = new System.Windows.Forms.Label();
            this.percentMonth3 = new System.Windows.Forms.Label();
            this.percentMonth6 = new System.Windows.Forms.Label();
            this.percentMonth9 = new System.Windows.Forms.Label();
            this.percentMonth12 = new System.Windows.Forms.Label();
            this.nameTb = new System.Windows.Forms.TextBox();
            this.percentMonth3Tb = new System.Windows.Forms.TextBox();
            this.percentMonth6Tb = new System.Windows.Forms.TextBox();
            this.percentMonth9Tb = new System.Windows.Forms.TextBox();
            this.percentMonth12Tb = new System.Windows.Forms.TextBox();
            this.typeCb = new System.Windows.Forms.ComboBox();
            this.currencyTypeCb = new System.Windows.Forms.ComboBox();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.back)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userPb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.infoPb)).BeginInit();
            this.SuspendLayout();
            // 
            // info
            // 
            this.info.AutoSize = true;
            this.info.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.info.Location = new System.Drawing.Point(294, 32);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(352, 22);
            this.info.TabIndex = 0;
            this.info.Text = "Інформація про депозитну програму";
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
            this.panel1.TabIndex = 1;
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
            // infoPb
            // 
            this.infoPb.Image = global::BankSystemApp.Properties.Resources.InfoIcon;
            this.infoPb.Location = new System.Drawing.Point(250, 23);
            this.infoPb.Name = "infoPb";
            this.infoPb.Size = new System.Drawing.Size(38, 38);
            this.infoPb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.infoPb.TabIndex = 2;
            this.infoPb.TabStop = false;
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.title.Location = new System.Drawing.Point(655, 27);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(215, 34);
            this.title.TabIndex = 3;
            this.title.Text = "BankDeposit";
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.name.Location = new System.Drawing.Point(250, 195);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(54, 18);
            this.name.TabIndex = 4;
            this.name.Text = "Назва";
            // 
            // type
            // 
            this.type.AutoSize = true;
            this.type.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.type.Location = new System.Drawing.Point(250, 230);
            this.type.Name = "type";
            this.type.Size = new System.Drawing.Size(35, 18);
            this.type.TabIndex = 5;
            this.type.Text = "Тип";
            // 
            // currencyType
            // 
            this.currencyType.AutoSize = true;
            this.currencyType.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.currencyType.Location = new System.Drawing.Point(250, 267);
            this.currencyType.Name = "currencyType";
            this.currencyType.Size = new System.Drawing.Size(65, 18);
            this.currencyType.TabIndex = 6;
            this.currencyType.Text = "Валюта";
            // 
            // percentMonth3
            // 
            this.percentMonth3.AutoSize = true;
            this.percentMonth3.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.percentMonth3.Location = new System.Drawing.Point(530, 167);
            this.percentMonth3.Name = "percentMonth3";
            this.percentMonth3.Size = new System.Drawing.Size(154, 18);
            this.percentMonth3.TabIndex = 7;
            this.percentMonth3.Text = "% річних (3 місяці)";
            // 
            // percentMonth6
            // 
            this.percentMonth6.AutoSize = true;
            this.percentMonth6.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.percentMonth6.Location = new System.Drawing.Point(530, 203);
            this.percentMonth6.Name = "percentMonth6";
            this.percentMonth6.Size = new System.Drawing.Size(163, 18);
            this.percentMonth6.TabIndex = 8;
            this.percentMonth6.Text = "% річних (6 місяців)";
            // 
            // percentMonth9
            // 
            this.percentMonth9.AutoSize = true;
            this.percentMonth9.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.percentMonth9.Location = new System.Drawing.Point(530, 239);
            this.percentMonth9.Name = "percentMonth9";
            this.percentMonth9.Size = new System.Drawing.Size(163, 18);
            this.percentMonth9.TabIndex = 9;
            this.percentMonth9.Text = "% річних (9 місяців)";
            // 
            // percentMonth12
            // 
            this.percentMonth12.AutoSize = true;
            this.percentMonth12.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.percentMonth12.Location = new System.Drawing.Point(530, 279);
            this.percentMonth12.Name = "percentMonth12";
            this.percentMonth12.Size = new System.Drawing.Size(173, 18);
            this.percentMonth12.TabIndex = 10;
            this.percentMonth12.Text = "% річних (12 місяців)";
            // 
            // nameTb
            // 
            this.nameTb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.nameTb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(244)))));
            this.nameTb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nameTb.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nameTb.Location = new System.Drawing.Point(345, 187);
            this.nameTb.Multiline = true;
            this.nameTb.Name = "nameTb";
            this.nameTb.Size = new System.Drawing.Size(164, 26);
            this.nameTb.TabIndex = 11;
            // 
            // percentMonth3Tb
            // 
            this.percentMonth3Tb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(244)))));
            this.percentMonth3Tb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.percentMonth3Tb.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.percentMonth3Tb.Location = new System.Drawing.Point(715, 159);
            this.percentMonth3Tb.Multiline = true;
            this.percentMonth3Tb.Name = "percentMonth3Tb";
            this.percentMonth3Tb.Size = new System.Drawing.Size(140, 26);
            this.percentMonth3Tb.TabIndex = 14;
            // 
            // percentMonth6Tb
            // 
            this.percentMonth6Tb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(244)))));
            this.percentMonth6Tb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.percentMonth6Tb.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.percentMonth6Tb.Location = new System.Drawing.Point(715, 195);
            this.percentMonth6Tb.Multiline = true;
            this.percentMonth6Tb.Name = "percentMonth6Tb";
            this.percentMonth6Tb.Size = new System.Drawing.Size(140, 26);
            this.percentMonth6Tb.TabIndex = 15;
            // 
            // percentMonth9Tb
            // 
            this.percentMonth9Tb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(244)))));
            this.percentMonth9Tb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.percentMonth9Tb.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.percentMonth9Tb.Location = new System.Drawing.Point(715, 231);
            this.percentMonth9Tb.Multiline = true;
            this.percentMonth9Tb.Name = "percentMonth9Tb";
            this.percentMonth9Tb.Size = new System.Drawing.Size(140, 26);
            this.percentMonth9Tb.TabIndex = 16;
            // 
            // percentMonth12Tb
            // 
            this.percentMonth12Tb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(244)))));
            this.percentMonth12Tb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.percentMonth12Tb.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.percentMonth12Tb.Location = new System.Drawing.Point(715, 271);
            this.percentMonth12Tb.Multiline = true;
            this.percentMonth12Tb.Name = "percentMonth12Tb";
            this.percentMonth12Tb.Size = new System.Drawing.Size(140, 26);
            this.percentMonth12Tb.TabIndex = 17;
            // 
            // typeCb
            // 
            this.typeCb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(244)))));
            this.typeCb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.typeCb.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.typeCb.FormattingEnabled = true;
            this.typeCb.Items.AddRange(new object[] {
            "Строковий",
            "До запитання"});
            this.typeCb.Location = new System.Drawing.Point(345, 222);
            this.typeCb.Name = "typeCb";
            this.typeCb.Size = new System.Drawing.Size(163, 26);
            this.typeCb.TabIndex = 18;
            // 
            // currencyTypeCb
            // 
            this.currencyTypeCb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(244)))));
            this.currencyTypeCb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.currencyTypeCb.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.currencyTypeCb.FormattingEnabled = true;
            this.currencyTypeCb.Items.AddRange(new object[] {
            "UAH",
            "USD",
            "EUR"});
            this.currencyTypeCb.Location = new System.Drawing.Point(345, 259);
            this.currencyTypeCb.Name = "currencyTypeCb";
            this.currencyTypeCb.Size = new System.Drawing.Size(163, 26);
            this.currencyTypeCb.TabIndex = 19;
            // 
            // deleteBtn
            // 
            this.deleteBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            this.deleteBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.deleteBtn.FlatAppearance.BorderSize = 0;
            this.deleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteBtn.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.deleteBtn.ForeColor = System.Drawing.Color.White;
            this.deleteBtn.Location = new System.Drawing.Point(652, 385);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(203, 44);
            this.deleteBtn.TabIndex = 20;
            this.deleteBtn.Text = "  Видалити";
            this.deleteBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.deleteBtn.UseVisualStyleBackColor = false;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // AdministratorAddEditDepositProgram
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(882, 453);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.currencyTypeCb);
            this.Controls.Add(this.typeCb);
            this.Controls.Add(this.percentMonth12Tb);
            this.Controls.Add(this.percentMonth9Tb);
            this.Controls.Add(this.percentMonth6Tb);
            this.Controls.Add(this.percentMonth3Tb);
            this.Controls.Add(this.nameTb);
            this.Controls.Add(this.percentMonth12);
            this.Controls.Add(this.percentMonth9);
            this.Controls.Add(this.percentMonth6);
            this.Controls.Add(this.percentMonth3);
            this.Controls.Add(this.currencyType);
            this.Controls.Add(this.type);
            this.Controls.Add(this.name);
            this.Controls.Add(this.title);
            this.Controls.Add(this.infoPb);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.info);
            this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AdministratorAddEditDepositProgram";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bank System - Deposit Program";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AdministratorAddEditDepositProgram_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.back)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userPb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.infoPb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label info;
        private Panel panel1;
        private Label user;
        private Button acceptBtn;
        private Label description;
        private PictureBox userPb;
        private PictureBox infoPb;
        private Label title;
        private Label name;
        private Label type;
        private Label currencyType;
        private Label percentMonth3;
        private Label percentMonth6;
        private Label percentMonth9;
        private Label percentMonth12;
        private TextBox nameTb;
        private TextBox percentMonth3Tb;
        private TextBox percentMonth6Tb;
        private TextBox percentMonth9Tb;
        private TextBox percentMonth12Tb;
        private ComboBox typeCb;
        private ComboBox currencyTypeCb;
        private PictureBox back;
        private Button deleteBtn;
    }
}