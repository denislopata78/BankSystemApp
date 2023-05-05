namespace BankSystemApp
{
    partial class Authorization
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Authorization));
            this.logInBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.passwordTb = new System.Windows.Forms.TextBox();
            this.inpTb = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.Label();
            this.inp = new System.Windows.Forms.Label();
            this.autorizationLabel = new System.Windows.Forms.Label();
            this.infoPb = new System.Windows.Forms.PictureBox();
            this.title = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.infoPb)).BeginInit();
            this.SuspendLayout();
            // 
            // logInBtn
            // 
            this.logInBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.logInBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.logInBtn.FlatAppearance.BorderSize = 0;
            this.logInBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logInBtn.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.logInBtn.Location = new System.Drawing.Point(74, 193);
            this.logInBtn.Name = "logInBtn";
            this.logInBtn.Size = new System.Drawing.Size(160, 26);
            this.logInBtn.TabIndex = 0;
            this.logInBtn.Text = "Вхід";
            this.logInBtn.UseVisualStyleBackColor = false;
            this.logInBtn.Click += new System.EventHandler(this.logInBtn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(225)))), ((int)(((byte)(233)))));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(410, 453);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(244)))));
            this.panel2.Controls.Add(this.passwordTb);
            this.panel2.Controls.Add(this.logInBtn);
            this.panel2.Controls.Add(this.inpTb);
            this.panel2.Controls.Add(this.password);
            this.panel2.Controls.Add(this.inp);
            this.panel2.Controls.Add(this.autorizationLabel);
            this.panel2.Location = new System.Drawing.Point(55, 106);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(300, 250);
            this.panel2.TabIndex = 0;
            // 
            // passwordTb
            // 
            this.passwordTb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passwordTb.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.passwordTb.Location = new System.Drawing.Point(153, 135);
            this.passwordTb.Multiline = true;
            this.passwordTb.Name = "passwordTb";
            this.passwordTb.PasswordChar = '*';
            this.passwordTb.Size = new System.Drawing.Size(130, 23);
            this.passwordTb.TabIndex = 4;
            // 
            // inpTb
            // 
            this.inpTb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.inpTb.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.inpTb.Location = new System.Drawing.Point(153, 89);
            this.inpTb.Multiline = true;
            this.inpTb.Name = "inpTb";
            this.inpTb.Size = new System.Drawing.Size(130, 23);
            this.inpTb.TabIndex = 3;
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.password.Location = new System.Drawing.Point(20, 140);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(65, 18);
            this.password.TabIndex = 2;
            this.password.Text = "Пароль";
            // 
            // inp
            // 
            this.inp.AutoSize = true;
            this.inp.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.inp.Location = new System.Drawing.Point(20, 94);
            this.inp.Name = "inp";
            this.inp.Size = new System.Drawing.Size(35, 18);
            this.inp.TabIndex = 1;
            this.inp.Text = "ІНП";
            // 
            // autorizationLabel
            // 
            this.autorizationLabel.AutoSize = true;
            this.autorizationLabel.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.autorizationLabel.Location = new System.Drawing.Point(57, 32);
            this.autorizationLabel.Name = "autorizationLabel";
            this.autorizationLabel.Size = new System.Drawing.Size(177, 28);
            this.autorizationLabel.TabIndex = 0;
            this.autorizationLabel.Text = "Авторизація";
            // 
            // infoPb
            // 
            this.infoPb.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.infoPb.Image = global::BankSystemApp.Properties.Resources.AuthorizationInform;
            this.infoPb.Location = new System.Drawing.Point(399, 79);
            this.infoPb.Name = "infoPb";
            this.infoPb.Size = new System.Drawing.Size(484, 299);
            this.infoPb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.infoPb.TabIndex = 4;
            this.infoPb.TabStop = false;
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.title.Location = new System.Drawing.Point(537, 33);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(215, 34);
            this.title.TabIndex = 5;
            this.title.Text = "BankDeposit";
            // 
            // Authorization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(882, 453);
            this.Controls.Add(this.title);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.infoPb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Authorization";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bank System - Authorization";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Authorization_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.infoPb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button logInBtn;
        private Panel panel1;
        private Panel panel2;
        private Label autorizationLabel;
        private TextBox passwordTb;
        private TextBox inpTb;
        private Label password;
        private Label inp;
        private PictureBox infoPb;
        private Label title;
    }
}