namespace UILayer
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.labelSuperShopName = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tbUserID = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.pBoxUser = new System.Windows.Forms.PictureBox();
            this.pBoxPass = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxPass)).BeginInit();
            this.SuspendLayout();
            // 
            // labelSuperShopName
            // 
            this.labelSuperShopName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelSuperShopName.BackColor = System.Drawing.Color.Transparent;
            this.labelSuperShopName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelSuperShopName.Font = new System.Drawing.Font("Monotype Corsiva", 45F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSuperShopName.ForeColor = System.Drawing.Color.Transparent;
            this.labelSuperShopName.Location = new System.Drawing.Point(136, 9);
            this.labelSuperShopName.Name = "labelSuperShopName";
            this.labelSuperShopName.Size = new System.Drawing.Size(513, 117);
            this.labelSuperShopName.TabIndex = 2;
            this.labelSuperShopName.Text = "Friend Super Shop";
            this.labelSuperShopName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.98176F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 86.01823F));
            this.tableLayoutPanel1.Controls.Add(this.tbUserID, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tbPassword, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.pBoxUser, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.pBoxPass, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(221, 151);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(329, 74);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // tbUserID
            // 
            this.tbUserID.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tbUserID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbUserID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUserID.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tbUserID.Location = new System.Drawing.Point(48, 3);
            this.tbUserID.Name = "tbUserID";
            this.tbUserID.Size = new System.Drawing.Size(278, 26);
            this.tbUserID.TabIndex = 0;
            // 
            // tbPassword
            // 
            this.tbPassword.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPassword.Location = new System.Drawing.Point(48, 40);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '*';
            this.tbPassword.Size = new System.Drawing.Size(278, 26);
            this.tbPassword.TabIndex = 1;
            this.tbPassword.UseSystemPasswordChar = true;
            // 
            // pBoxUser
            // 
            this.pBoxUser.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pBoxUser.BackgroundImage")));
            this.pBoxUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pBoxUser.Location = new System.Drawing.Point(3, 3);
            this.pBoxUser.Name = "pBoxUser";
            this.pBoxUser.Size = new System.Drawing.Size(39, 30);
            this.pBoxUser.TabIndex = 2;
            this.pBoxUser.TabStop = false;
            // 
            // pBoxPass
            // 
            this.pBoxPass.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pBoxPass.BackgroundImage")));
            this.pBoxPass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pBoxPass.Location = new System.Drawing.Point(3, 40);
            this.pBoxPass.Name = "pBoxPass";
            this.pBoxPass.Size = new System.Drawing.Size(39, 31);
            this.pBoxPass.TabIndex = 3;
            this.pBoxPass.TabStop = false;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(770, 377);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.labelSuperShopName);
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxPass)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelSuperShopName;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox tbUserID;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.PictureBox pBoxUser;
        private System.Windows.Forms.PictureBox pBoxPass;
    }
}