using System.Windows.Forms;

namespace BankSystemApp
{
    partial class AdministratorDepositPrograms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdministratorDepositPrograms));
            this.addDepositProgramBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.back = new System.Windows.Forms.PictureBox();
            this.userPb = new System.Windows.Forms.PictureBox();
            this.description = new System.Windows.Forms.Label();
            this.user = new System.Windows.Forms.Label();
            this.subtitlePb = new System.Windows.Forms.PictureBox();
            this.title = new System.Windows.Forms.Label();
            this.subtitle = new System.Windows.Forms.Label();
            this.depositProgramsPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.back)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userPb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subtitlePb)).BeginInit();
            this.SuspendLayout();
            // 
            // addDepositProgramBtn
            // 
            this.addDepositProgramBtn.BackColor = System.Drawing.Color.White;
            this.addDepositProgramBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.addDepositProgramBtn.FlatAppearance.BorderSize = 0;
            this.addDepositProgramBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addDepositProgramBtn.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addDepositProgramBtn.Location = new System.Drawing.Point(28, 135);
            this.addDepositProgramBtn.Name = "addDepositProgramBtn";
            this.addDepositProgramBtn.Size = new System.Drawing.Size(314, 58);
            this.addDepositProgramBtn.TabIndex = 0;
            this.addDepositProgramBtn.Text = "     Додати депозитну програму";
            this.addDepositProgramBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addDepositProgramBtn.UseVisualStyleBackColor = false;
            this.addDepositProgramBtn.Click += new System.EventHandler(this.addDepositProgramBtn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(225)))), ((int)(((byte)(233)))));
            this.panel1.Controls.Add(this.back);
            this.panel1.Controls.Add(this.userPb);
            this.panel1.Controls.Add(this.description);
            this.panel1.Controls.Add(this.user);
            this.panel1.Controls.Add(this.addDepositProgramBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(410, 453);
            this.panel1.TabIndex = 1;
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
            this.description.Size = new System.Drawing.Size(324, 32);
            this.description.TabIndex = 6;
            this.description.Text = "* Для редагування необхідного депозиту \r\nклікніть по відповідному полю поруч з на" +
    "звою\r\n";
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
            // subtitlePb
            // 
            this.subtitlePb.Image = global::BankSystemApp.Properties.Resources.CardIcon;
            this.subtitlePb.Location = new System.Drawing.Point(436, 71);
            this.subtitlePb.Name = "subtitlePb";
            this.subtitlePb.Size = new System.Drawing.Size(30, 30);
            this.subtitlePb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.subtitlePb.TabIndex = 3;
            this.subtitlePb.TabStop = false;
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.title.Location = new System.Drawing.Point(541, 25);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(215, 34);
            this.title.TabIndex = 4;
            this.title.Text = "BankDeposit";
            // 
            // subtitle
            // 
            this.subtitle.AutoSize = true;
            this.subtitle.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.subtitle.Location = new System.Drawing.Point(472, 76);
            this.subtitle.Name = "subtitle";
            this.subtitle.Size = new System.Drawing.Size(358, 22);
            this.subtitle.TabIndex = 7;
            this.subtitle.Text = "Список наявних депозитних програм";
            // 
            // depositProgramsPanel
            // 
            this.depositProgramsPanel.AutoScroll = true;
            this.depositProgramsPanel.AutoSize = true;
            this.depositProgramsPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.depositProgramsPanel.Location = new System.Drawing.Point(435, 114);
            this.depositProgramsPanel.MaximumSize = new System.Drawing.Size(435, 315);
            this.depositProgramsPanel.Name = "depositProgramsPanel";
            this.depositProgramsPanel.Size = new System.Drawing.Size(435, 315);
            this.depositProgramsPanel.TabIndex = 8;
            this.depositProgramsPanel.WrapContents = false;
            // 
            // AdministratorDepositPrograms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(882, 453);
            this.Controls.Add(this.depositProgramsPanel);
            this.Controls.Add(this.subtitle);
            this.Controls.Add(this.title);
            this.Controls.Add(this.subtitlePb);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AdministratorDepositPrograms";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bank System - Deposit Programs";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AdministratorDepositPrograms_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.back)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userPb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subtitlePb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button addDepositProgramBtn;
        private Panel panel1;
        private PictureBox userPb;
        private PictureBox subtitlePb;
        private Label title;
        private Label user;
        private Label description;
        private Label subtitle;
        private FlowLayoutPanel depositProgramsPanel;
        private PictureBox back;
    }
}