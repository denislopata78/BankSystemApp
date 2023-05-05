namespace BankSystemApp
{
    partial class AdministratorClients
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdministratorClients));
            this.panel1 = new System.Windows.Forms.Panel();
            this.back = new System.Windows.Forms.PictureBox();
            this.userPb = new System.Windows.Forms.PictureBox();
            this.description = new System.Windows.Forms.Label();
            this.user = new System.Windows.Forms.Label();
            this.addClientBtn = new System.Windows.Forms.Button();
            this.title = new System.Windows.Forms.Label();
            this.clientPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.subtitlePb = new System.Windows.Forms.PictureBox();
            this.subtitle = new System.Windows.Forms.Label();
            this.searchTb = new System.Windows.Forms.TextBox();
            this.searchPb = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.back)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userPb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subtitlePb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchPb)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(225)))), ((int)(((byte)(233)))));
            this.panel1.Controls.Add(this.back);
            this.panel1.Controls.Add(this.userPb);
            this.panel1.Controls.Add(this.description);
            this.panel1.Controls.Add(this.user);
            this.panel1.Controls.Add(this.addClientBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(410, 453);
            this.panel1.TabIndex = 2;
            // 
            // back
            // 
            this.back.Image = global::BankSystemApp.Properties.Resources.BackIcon;
            this.back.Location = new System.Drawing.Point(28, 396);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(30, 30);
            this.back.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.back.TabIndex = 7;
            this.back.TabStop = false;
            this.back.Click += new System.EventHandler(this.back_Click);
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
            // description
            // 
            this.description.AutoSize = true;
            this.description.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.description.Location = new System.Drawing.Point(28, 215);
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(322, 32);
            this.description.TabIndex = 6;
            this.description.Text = "* Для перегляду або редагування інформації \r\nпро клієнта клікніть по іконці поруч" +
    " з ПІБ\r\n";
            // 
            // user
            // 
            this.user.AutoSize = true;
            this.user.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.user.Location = new System.Drawing.Point(74, 35);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(139, 22);
            this.user.TabIndex = 5;
            this.user.Text = "Адміністратор";
            // 
            // addClientBtn
            // 
            this.addClientBtn.BackColor = System.Drawing.Color.White;
            this.addClientBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.addClientBtn.FlatAppearance.BorderSize = 0;
            this.addClientBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addClientBtn.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addClientBtn.Location = new System.Drawing.Point(28, 135);
            this.addClientBtn.Name = "addClientBtn";
            this.addClientBtn.Size = new System.Drawing.Size(314, 58);
            this.addClientBtn.TabIndex = 0;
            this.addClientBtn.Text = "     Додати";
            this.addClientBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addClientBtn.UseVisualStyleBackColor = false;
            this.addClientBtn.Click += new System.EventHandler(this.addClientBtn_Click);
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.title.Location = new System.Drawing.Point(541, 25);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(215, 34);
            this.title.TabIndex = 5;
            this.title.Text = "BankDeposit";
            // 
            // clientPanel
            // 
            this.clientPanel.AutoScroll = true;
            this.clientPanel.Location = new System.Drawing.Point(435, 114);
            this.clientPanel.Name = "clientPanel";
            this.clientPanel.Size = new System.Drawing.Size(435, 315);
            this.clientPanel.TabIndex = 6;
            // 
            // subtitlePb
            // 
            this.subtitlePb.Image = global::BankSystemApp.Properties.Resources.UsersIcon;
            this.subtitlePb.Location = new System.Drawing.Point(436, 71);
            this.subtitlePb.Name = "subtitlePb";
            this.subtitlePb.Size = new System.Drawing.Size(30, 30);
            this.subtitlePb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.subtitlePb.TabIndex = 7;
            this.subtitlePb.TabStop = false;
            this.subtitlePb.Click += new System.EventHandler(this.subtitlePb_Click);
            // 
            // subtitle
            // 
            this.subtitle.AutoSize = true;
            this.subtitle.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.subtitle.Location = new System.Drawing.Point(472, 76);
            this.subtitle.Name = "subtitle";
            this.subtitle.Size = new System.Drawing.Size(157, 22);
            this.subtitle.TabIndex = 8;
            this.subtitle.Text = "Список клієнтів";
            // 
            // searchTb
            // 
            this.searchTb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.searchTb.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.searchTb.Location = new System.Drawing.Point(647, 73);
            this.searchTb.Multiline = true;
            this.searchTb.Name = "searchTb";
            this.searchTb.Size = new System.Drawing.Size(186, 26);
            this.searchTb.TabIndex = 9;
            // 
            // searchPb
            // 
            this.searchPb.Image = global::BankSystemApp.Properties.Resources.FindIcon;
            this.searchPb.Location = new System.Drawing.Point(839, 64);
            this.searchPb.Name = "searchPb";
            this.searchPb.Size = new System.Drawing.Size(31, 31);
            this.searchPb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.searchPb.TabIndex = 10;
            this.searchPb.TabStop = false;
            this.searchPb.Click += new System.EventHandler(this.searchPb_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(648, 101);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(222, 1);
            this.panel2.TabIndex = 11;
            // 
            // AdministratorClients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(882, 453);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.searchPb);
            this.Controls.Add(this.searchTb);
            this.Controls.Add(this.subtitle);
            this.Controls.Add(this.subtitlePb);
            this.Controls.Add(this.clientPanel);
            this.Controls.Add(this.title);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AdministratorClients";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bank System - Clients";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AdministratorClients_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.back)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userPb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subtitlePb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchPb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Panel panel1;
        private PictureBox back;
        private PictureBox userPb;
        private Label description;
        private Label user;
        private Button addClientBtn;
        private Label title;
        private FlowLayoutPanel clientPanel;
        private PictureBox subtitlePb;
        private Label subtitle;
        private TextBox searchTb;
        private PictureBox searchPb;
        private Panel panel2;
    }
}