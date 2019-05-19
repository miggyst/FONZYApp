namespace FONZY
{
	partial class CodeDetails
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
            this.tinLabel = new System.Windows.Forms.Label();
            this.businessStyleLabel = new System.Windows.Forms.Label();
            this.termsLabel = new System.Windows.Forms.Label();
            this.oscaLabel = new System.Windows.Forms.Label();
            this.tinTextBox = new System.Windows.Forms.TextBox();
            this.businessStyleTextBox = new System.Windows.Forms.TextBox();
            this.termsTextBox = new System.Windows.Forms.TextBox();
            this.oscaTextBox = new System.Windows.Forms.TextBox();
            this.proceedButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tinLabel
            // 
            this.tinLabel.AutoSize = true;
            this.tinLabel.Location = new System.Drawing.Point(25, 25);
            this.tinLabel.Name = "tinLabel";
            this.tinLabel.Size = new System.Drawing.Size(25, 13);
            this.tinLabel.TabIndex = 0;
            this.tinLabel.Text = "TIN";
            // 
            // businessStyleLabel
            // 
            this.businessStyleLabel.AutoSize = true;
            this.businessStyleLabel.Location = new System.Drawing.Point(25, 50);
            this.businessStyleLabel.Name = "businessStyleLabel";
            this.businessStyleLabel.Size = new System.Drawing.Size(75, 13);
            this.businessStyleLabel.TabIndex = 1;
            this.businessStyleLabel.Text = "Business Style";
            // 
            // termsLabel
            // 
            this.termsLabel.AutoSize = true;
            this.termsLabel.Location = new System.Drawing.Point(25, 75);
            this.termsLabel.Name = "termsLabel";
            this.termsLabel.Size = new System.Drawing.Size(36, 13);
            this.termsLabel.TabIndex = 2;
            this.termsLabel.Text = "Terms";
            // 
            // oscaLabel
            // 
            this.oscaLabel.AutoSize = true;
            this.oscaLabel.Location = new System.Drawing.Point(25, 100);
            this.oscaLabel.Name = "oscaLabel";
            this.oscaLabel.Size = new System.Drawing.Size(98, 13);
            this.oscaLabel.TabIndex = 3;
            this.oscaLabel.Text = "OSCA/PWD ID No";
            // 
            // tinTextBox
            // 
            this.tinTextBox.Location = new System.Drawing.Point(142, 22);
            this.tinTextBox.Name = "tinTextBox";
            this.tinTextBox.Size = new System.Drawing.Size(140, 20);
            this.tinTextBox.TabIndex = 4;
            // 
            // businessStyleTextBox
            // 
            this.businessStyleTextBox.Location = new System.Drawing.Point(142, 48);
            this.businessStyleTextBox.Name = "businessStyleTextBox";
            this.businessStyleTextBox.Size = new System.Drawing.Size(140, 20);
            this.businessStyleTextBox.TabIndex = 5;
            // 
            // termsTextBox
            // 
            this.termsTextBox.Location = new System.Drawing.Point(142, 72);
            this.termsTextBox.Name = "termsTextBox";
            this.termsTextBox.Size = new System.Drawing.Size(140, 20);
            this.termsTextBox.TabIndex = 6;
            // 
            // oscaTextBox
            // 
            this.oscaTextBox.Location = new System.Drawing.Point(142, 97);
            this.oscaTextBox.Name = "oscaTextBox";
            this.oscaTextBox.Size = new System.Drawing.Size(140, 20);
            this.oscaTextBox.TabIndex = 7;
            // 
            // proceedButton
            // 
            this.proceedButton.Location = new System.Drawing.Point(25, 126);
            this.proceedButton.Name = "proceedButton";
            this.proceedButton.Size = new System.Drawing.Size(75, 23);
            this.proceedButton.TabIndex = 8;
            this.proceedButton.Text = "Proceed";
            this.proceedButton.UseVisualStyleBackColor = true;
            this.proceedButton.Click += new System.EventHandler(this.ProceedButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(207, 126);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 9;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // CodeDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 161);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.proceedButton);
            this.Controls.Add(this.oscaTextBox);
            this.Controls.Add(this.termsTextBox);
            this.Controls.Add(this.businessStyleTextBox);
            this.Controls.Add(this.tinTextBox);
            this.Controls.Add(this.oscaLabel);
            this.Controls.Add(this.termsLabel);
            this.Controls.Add(this.businessStyleLabel);
            this.Controls.Add(this.tinLabel);
            this.Name = "CodeDetails";
            this.Text = "Code Details";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CodeDetails_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

        #endregion

        private System.Windows.Forms.Label tinLabel;
        private System.Windows.Forms.Label businessStyleLabel;
        private System.Windows.Forms.Label termsLabel;
        private System.Windows.Forms.Label oscaLabel;
        private System.Windows.Forms.TextBox tinTextBox;
        private System.Windows.Forms.TextBox businessStyleTextBox;
        private System.Windows.Forms.TextBox termsTextBox;
        private System.Windows.Forms.TextBox oscaTextBox;
        private System.Windows.Forms.Button proceedButton;
        private System.Windows.Forms.Button exitButton;
    }
}