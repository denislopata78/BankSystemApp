namespace BankSystemApp
{
    partial class ClientWithdraw
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientWithdraw));
            this.title = new System.Windows.Forms.Label();
            this.acceptBtn = new System.Windows.Forms.Button();
            this.amountTb = new System.Windows.Forms.TextBox();
            this.amount = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.title.Location = new System.Drawing.Point(63, 9);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(174, 28);
            this.title.TabIndex = 6;
            this.title.Text = "BankDeposit";
            // 
            // acceptBtn
            // 
            this.acceptBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(244)))));
            this.acceptBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.acceptBtn.FlatAppearance.BorderSize = 0;
            this.acceptBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.acceptBtn.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.acceptBtn.Location = new System.Drawing.Point(158, 103);
            this.acceptBtn.Name = "acceptBtn";
            this.acceptBtn.Size = new System.Drawing.Size(131, 31);
            this.acceptBtn.TabIndex = 12;
            this.acceptBtn.Text = "  Підтвердити";
            this.acceptBtn.UseVisualStyleBackColor = false;
            this.acceptBtn.Click += new System.EventHandler(this.acceptBtn_Click);
            // 
            // amountTb
            // 
            this.amountTb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.amountTb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(244)))));
            this.amountTb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.amountTb.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.amountTb.Location = new System.Drawing.Point(136, 53);
            this.amountTb.Multiline = true;
            this.amountTb.Name = "amountTb";
            this.amountTb.Size = new System.Drawing.Size(153, 26);
            this.amountTb.TabIndex = 14;
            // 
            // amount
            // 
            this.amount.AutoSize = true;
            this.amount.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.amount.Location = new System.Drawing.Point(12, 61);
            this.amount.Name = "amount";
            this.amount.Size = new System.Drawing.Size(101, 18);
            this.amount.TabIndex = 13;
            this.amount.Text = "Сума зняття";
            // 
            // ClientWithdraw
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(301, 146);
            this.Controls.Add(this.acceptBtn);
            this.Controls.Add(this.amountTb);
            this.Controls.Add(this.amount);
            this.Controls.Add(this.title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ClientWithdraw";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bank - Withdraw";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label title;
        private Button acceptBtn;
        private TextBox amountTb;
        private Label amount;
    }
}