namespace loginProjectRyanBos
{
    partial class homePage
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.welcomeBackLabel = new System.Windows.Forms.Label();
            this.logoutButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // welcomeBackLabel
            // 
            this.welcomeBackLabel.AutoSize = true;
            this.welcomeBackLabel.Location = new System.Drawing.Point(110, 84);
            this.welcomeBackLabel.Name = "welcomeBackLabel";
            this.welcomeBackLabel.Size = new System.Drawing.Size(80, 13);
            this.welcomeBackLabel.TabIndex = 0;
            this.welcomeBackLabel.Text = "Welcome Back";
            // 
            // logoutButton
            // 
            this.logoutButton.Location = new System.Drawing.Point(113, 199);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(75, 23);
            this.logoutButton.TabIndex = 1;
            this.logoutButton.Text = "LOG OUT";
            this.logoutButton.UseVisualStyleBackColor = true;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // homePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Blue;
            this.Controls.Add(this.logoutButton);
            this.Controls.Add(this.welcomeBackLabel);
            this.Name = "homePage";
            this.Size = new System.Drawing.Size(300, 300);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label welcomeBackLabel;
        private System.Windows.Forms.Button logoutButton;
    }
}
