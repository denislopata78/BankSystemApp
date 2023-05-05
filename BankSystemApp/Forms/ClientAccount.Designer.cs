namespace BankSystemApp
{
    partial class ClientAccount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientAccount));
            this.panel1 = new System.Windows.Forms.Panel();
            this.infoBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.amountUSD = new System.Windows.Forms.Label();
            this.amountEUR = new System.Windows.Forms.Label();
            this.amountUAH = new System.Windows.Forms.Label();
            this.back = new System.Windows.Forms.PictureBox();
            this.user = new System.Windows.Forms.Label();
            this.openBtn = new System.Windows.Forms.Button();
            this.description = new System.Windows.Forms.Label();
            this.userPb = new System.Windows.Forms.PictureBox();
            this.infoPb = new System.Windows.Forms.PictureBox();
            this.info2 = new System.Windows.Forms.Label();
            this.title = new System.Windows.Forms.Label();
            this.depositsPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.textBackP = new System.Windows.Forms.Label();
            this.backP = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.back)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userPb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.infoPb)).BeginInit();
            this.backP.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(225)))), ((int)(((byte)(233)))));
            this.panel1.Controls.Add(this.infoBtn);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.amountUSD);
            this.panel1.Controls.Add(this.amountEUR);
            this.panel1.Controls.Add(this.amountUAH);
            this.panel1.Controls.Add(this.back);
            this.panel1.Controls.Add(this.user);
            this.panel1.Controls.Add(this.openBtn);
            this.panel1.Controls.Add(this.description);
            this.panel1.Controls.Add(this.userPb);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(235, 453);
            this.panel1.TabIndex = 3;
            // 
            // infoBtn
            // 
            this.infoBtn.BackColor = System.Drawing.Color.White;
            this.infoBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.infoBtn.FlatAppearance.BorderSize = 0;
            this.infoBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.infoBtn.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.infoBtn.Location = new System.Drawing.Point(17, 210);
            this.infoBtn.Name = "infoBtn";
            this.infoBtn.Size = new System.Drawing.Size(203, 44);
            this.infoBtn.TabIndex = 24;
            this.infoBtn.Text = "  Контактна інформація";
            this.infoBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.infoBtn.UseVisualStyleBackColor = false;
            this.infoBtn.Click += new System.EventHandler(this.infoBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(17, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 20);
            this.label1.TabIndex = 23;
            this.label1.Text = "Баланс";
            // 
            // amountUSD
            // 
            this.amountUSD.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.amountUSD.Location = new System.Drawing.Point(98, 116);
            this.amountUSD.Name = "amountUSD";
            this.amountUSD.Size = new System.Drawing.Size(129, 18);
            this.amountUSD.TabIndex = 21;
            this.amountUSD.Text = "0 EUR";
            this.amountUSD.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // amountEUR
            // 
            this.amountEUR.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.amountEUR.Location = new System.Drawing.Point(101, 95);
            this.amountEUR.Name = "amountEUR";
            this.amountEUR.Size = new System.Drawing.Size(126, 20);
            this.amountEUR.TabIndex = 19;
            this.amountEUR.Text = "0 USD";
            this.amountEUR.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // amountUAH
            // 
            this.amountUAH.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.amountUAH.Location = new System.Drawing.Point(101, 75);
            this.amountUAH.Name = "amountUAH";
            this.amountUAH.Size = new System.Drawing.Size(126, 20);
            this.amountUAH.TabIndex = 17;
            this.amountUAH.Text = "0 UAH";
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
            this.user.Location = new System.Drawing.Point(68, 32);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(159, 22);
            this.user.TabIndex = 3;
            this.user.Text = "Адміністратор";
            this.user.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // openBtn
            // 
            this.openBtn.BackColor = System.Drawing.Color.White;
            this.openBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.openBtn.FlatAppearance.BorderSize = 0;
            this.openBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.openBtn.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.openBtn.Location = new System.Drawing.Point(17, 160);
            this.openBtn.Name = "openBtn";
            this.openBtn.Size = new System.Drawing.Size(203, 44);
            this.openBtn.TabIndex = 2;
            this.openBtn.Text = "  Відкрити депозит";
            this.openBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.openBtn.UseVisualStyleBackColor = false;
            this.openBtn.Click += new System.EventHandler(this.openBtn_Click);
            // 
            // description
            // 
            this.description.AutoSize = true;
            this.description.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.description.Location = new System.Drawing.Point(17, 266);
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(193, 48);
            this.description.TabIndex = 1;
            this.description.Text = "* Баланс розраховано без \r\nнарахованих відсотків за \r\nдепозитами";
            // 
            // userPb
            // 
            this.userPb.Image = global::BankSystemApp.Properties.Resources.UserIcon;
            this.userPb.Location = new System.Drawing.Point(17, 23);
            this.userPb.Name = "userPb";
            this.userPb.Size = new System.Drawing.Size(40, 40);
            this.userPb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.userPb.TabIndex = 0;
            this.userPb.TabStop = false;
            // 
            // infoPb
            // 
            this.infoPb.Image = global::BankSystemApp.Properties.Resources.CardIcon;
            this.infoPb.Location = new System.Drawing.Point(276, 64);
            this.infoPb.Name = "infoPb";
            this.infoPb.Size = new System.Drawing.Size(30, 30);
            this.infoPb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.infoPb.TabIndex = 11;
            this.infoPb.TabStop = false;
            // 
            // info2
            // 
            this.info2.AutoSize = true;
            this.info2.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.info2.Location = new System.Drawing.Point(312, 72);
            this.info2.Name = "info2";
            this.info2.Size = new System.Drawing.Size(178, 22);
            this.info2.TabIndex = 10;
            this.info2.Text = "Відкриті депозити";
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.title.Location = new System.Drawing.Point(631, 23);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(215, 34);
            this.title.TabIndex = 9;
            this.title.Text = "BankDeposit";
            // 
            // depositsPanel
            // 
            this.depositsPanel.AutoScroll = true;
            this.depositsPanel.Location = new System.Drawing.Point(276, 116);
            this.depositsPanel.Name = "depositsPanel";
            this.depositsPanel.Size = new System.Drawing.Size(570, 325);
            this.depositsPanel.TabIndex = 12;
            // 
            // textBackP
            // 
            this.textBackP.AutoSize = true;
            this.textBackP.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBackP.Location = new System.Drawing.Point(51, 128);
            this.textBackP.Name = "textBackP";
            this.textBackP.Size = new System.Drawing.Size(469, 22);
            this.textBackP.TabIndex = 13;
            this.textBackP.Text = "Наразі у Вас немає жодного відкритого депозиту";
            // 
            // backP
            // 
            this.backP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(244)))));
            this.backP.Controls.Add(this.textBackP);
            this.backP.Location = new System.Drawing.Point(276, 116);
            this.backP.Name = "backP";
            this.backP.Size = new System.Drawing.Size(570, 297);
            this.backP.TabIndex = 14;
            // 
            // ClientAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(882, 453);
            this.Controls.Add(this.backP);
            this.Controls.Add(this.depositsPanel);
            this.Controls.Add(this.infoPb);
            this.Controls.Add(this.info2);
            this.Controls.Add(this.title);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ClientAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bank System - Client Account";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ClientAccount_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.back)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userPb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.infoPb)).EndInit();
            this.backP.ResumeLayout(false);
            this.backP.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private PictureBox back;
        private Label user;
        private Button openBtn;
        private Label description;
        private PictureBox userPb;
        private PictureBox infoPb;
        private Label info2;
        private Label title;
        private FlowLayoutPanel depositsPanel;
        private Label label1;
        private Label amountUSD;
        private Label amountEUR;
        private Label amountUAH;
        private Button infoBtn;
        private Label textBackP;
        private Panel backP;
    }
}