namespace BankSystemApp
{   
    partial class AdministratorMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdministratorMenu));
            this.back = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.depositProgramsBtn = new System.Windows.Forms.Button();
            this.clientsBtn = new System.Windows.Forms.Button();
            this.userPb = new System.Windows.Forms.PictureBox();
            this.user = new System.Windows.Forms.Label();
            this.infoPb = new System.Windows.Forms.PictureBox();
            this.title = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.back)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userPb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.infoPb)).BeginInit();
            this.SuspendLayout();
            // 
            // back
            // 
            this.back.Image = global::BankSystemApp.Properties.Resources.BackIcon;
            this.back.Location = new System.Drawing.Point(28, 396);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(30, 30);
            this.back.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.back.TabIndex = 2;
            this.back.TabStop = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(225)))), ((int)(((byte)(233)))));
            this.panel1.Controls.Add(this.depositProgramsBtn);
            this.panel1.Controls.Add(this.clientsBtn);
            this.panel1.Controls.Add(this.userPb);
            this.panel1.Controls.Add(this.back);
            this.panel1.Controls.Add(this.user);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(410, 453);
            this.panel1.TabIndex = 3;
            // 
            // depositProgramsBtn
            // 
            this.depositProgramsBtn.BackColor = System.Drawing.Color.White;
            this.depositProgramsBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.depositProgramsBtn.FlatAppearance.BorderSize = 0;
            this.depositProgramsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.depositProgramsBtn.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.depositProgramsBtn.Location = new System.Drawing.Point(28, 230);
            this.depositProgramsBtn.Name = "depositProgramsBtn";
            this.depositProgramsBtn.Size = new System.Drawing.Size(314, 58);
            this.depositProgramsBtn.TabIndex = 7;
            this.depositProgramsBtn.Text = "    Робота з депозитними програмами\r\n";
            this.depositProgramsBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.depositProgramsBtn.UseVisualStyleBackColor = false;
            this.depositProgramsBtn.Click += new System.EventHandler(this.depositProgramsBtn_Click);
            // 
            // clientsBtn
            // 
            this.clientsBtn.BackColor = System.Drawing.Color.White;
            this.clientsBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.clientsBtn.FlatAppearance.BorderSize = 0;
            this.clientsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clientsBtn.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.clientsBtn.Location = new System.Drawing.Point(28, 157);
            this.clientsBtn.Name = "clientsBtn";
            this.clientsBtn.Size = new System.Drawing.Size(314, 58);
            this.clientsBtn.TabIndex = 6;
            this.clientsBtn.Text = "    Робота з клієнтами";
            this.clientsBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.clientsBtn.UseVisualStyleBackColor = false;
            this.clientsBtn.Click += new System.EventHandler(this.clientsBtn_Click);
            // 
            // userPb
            // 
            this.userPb.Image = global::BankSystemApp.Properties.Resources.UserIcon;
            this.userPb.Location = new System.Drawing.Point(28, 26);
            this.userPb.Name = "userPb";
            this.userPb.Size = new System.Drawing.Size(40, 40);
            this.userPb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.userPb.TabIndex = 2;
            this.userPb.TabStop = false;
            // 
            // user
            // 
            this.user.AutoSize = true;
            this.user.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.user.Location = new System.Drawing.Point(85, 35);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(139, 22);
            this.user.TabIndex = 5;
            this.user.Text = "Адміністратор";
            // 
            // infoPb
            // 
            this.infoPb.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.infoPb.Image = global::BankSystemApp.Properties.Resources.AuthorizationInform;
            this.infoPb.Location = new System.Drawing.Point(401, 80);
            this.infoPb.Name = "infoPb";
            this.infoPb.Size = new System.Drawing.Size(484, 299);
            this.infoPb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.infoPb.TabIndex = 5;
            this.infoPb.TabStop = false;
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.title.Location = new System.Drawing.Point(539, 26);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(215, 34);
            this.title.TabIndex = 6;
            this.title.Text = "BankDeposit";
            // 
            // AdministratorMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(882, 453);
            this.Controls.Add(this.title);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.infoPb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AdministratorMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bank System - Admin menu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AdministratorMenu_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.back)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userPb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.infoPb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private PictureBox back;
        private Panel panel1;
        private PictureBox userPb;
        private Label user;
        private Button depositProgramsBtn;
        private Button clientsBtn;
        private PictureBox infoPb;
        private Label title;
    }
}