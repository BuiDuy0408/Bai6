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
            this.label1 = new System.Windows.Forms.Label();
            this.pBoxUser = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxUser)).BeginInit();
            this.SuspendLayout();
            // 
            // labelSuperShopName
            // 
            this.labelSuperShopName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelSuperShopName.BackColor = System.Drawing.Color.Transparent;
            this.labelSuperShopName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelSuperShopName.Font = new System.Drawing.Font("Monotype Corsiva", 45F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSuperShopName.ForeColor = System.Drawing.Color.Transparent;
            this.labelSuperShopName.Location = new System.Drawing.Point(132, 36);
            this.labelSuperShopName.Name = "labelSuperShopName";
            this.labelSuperShopName.Size = new System.Drawing.Size(513, 117);
            this.labelSuperShopName.TabIndex = 2;
            this.labelSuperShopName.Text = "Friend Super Shop";
            this.labelSuperShopName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 26.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(174, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 55);
            this.label1.TabIndex = 3;
            this.label1.Text = "Login";
            // 
            // pBoxUser
            // 
            this.pBoxUser.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pBoxUser.BackgroundImage")));
            this.pBoxUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pBoxUser.Location = new System.Drawing.Point(202, 189);
            this.pBoxUser.Name = "pBoxUser";
            this.pBoxUser.Size = new System.Drawing.Size(39, 30);
            this.pBoxUser.TabIndex = 4;
            this.pBoxUser.TabStop = false;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 377);
            this.Controls.Add(this.pBoxUser);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelSuperShopName);
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            ((System.ComponentModel.ISupportInitialize)(this.pBoxUser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelSuperShopName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pBoxUser;
    }
}