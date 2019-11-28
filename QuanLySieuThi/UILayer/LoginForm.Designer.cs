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
            this.labelSuperShopName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelSuperShopName
            // 
            this.labelSuperShopName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelSuperShopName.BackColor = System.Drawing.Color.Transparent;
            this.labelSuperShopName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelSuperShopName.Font = new System.Drawing.Font("Monotype Corsiva", 45F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSuperShopName.ForeColor = System.Drawing.Color.Transparent;
            this.labelSuperShopName.Location = new System.Drawing.Point(181, 11);
            this.labelSuperShopName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSuperShopName.Name = "labelSuperShopName";
            this.labelSuperShopName.Size = new System.Drawing.Size(684, 144);
            this.labelSuperShopName.TabIndex = 2;
            this.labelSuperShopName.Text = "Friend Super Shop";
            this.labelSuperShopName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1027, 464);
            this.Controls.Add(this.labelSuperShopName);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelSuperShopName;
    }
}