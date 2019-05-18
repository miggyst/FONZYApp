namespace FONZY
{
	partial class ChooseApplication
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
            this.inventoryButton = new System.Windows.Forms.Button();
            this.transactionButton = new System.Windows.Forms.Button();
            this.applicationModeLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // inventoryButton
            // 
            this.inventoryButton.Location = new System.Drawing.Point(40, 40);
            this.inventoryButton.Name = "inventoryButton";
            this.inventoryButton.Size = new System.Drawing.Size(75, 23);
            this.inventoryButton.TabIndex = 0;
            this.inventoryButton.Text = "Inventory";
            this.inventoryButton.UseVisualStyleBackColor = true;
            this.inventoryButton.Click += new System.EventHandler(this.InventoryButton_Click);
            // 
            // transactionButton
            // 
            this.transactionButton.Location = new System.Drawing.Point(160, 40);
            this.transactionButton.Name = "transactionButton";
            this.transactionButton.Size = new System.Drawing.Size(75, 23);
            this.transactionButton.TabIndex = 1;
            this.transactionButton.Text = "Transaction";
            this.transactionButton.UseVisualStyleBackColor = true;
            this.transactionButton.Click += new System.EventHandler(this.TransactionButton_Click);
            // 
            // applicationModeLabel
            // 
            this.applicationModeLabel.AutoSize = true;
            this.applicationModeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.applicationModeLabel.Location = new System.Drawing.Point(30, 20);
            this.applicationModeLabel.Name = "applicationModeLabel";
            this.applicationModeLabel.Size = new System.Drawing.Size(214, 13);
            this.applicationModeLabel.TabIndex = 2;
            this.applicationModeLabel.Text = "Please choose the correct application mode";
            this.applicationModeLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ChooseApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 81);
            this.Controls.Add(this.applicationModeLabel);
            this.Controls.Add(this.transactionButton);
            this.Controls.Add(this.inventoryButton);
            this.Name = "ChooseApplication";
            this.Text = "Application Mode";
            this.ResumeLayout(false);
            this.PerformLayout();

		}

        #endregion

        private System.Windows.Forms.Button inventoryButton;
        private System.Windows.Forms.Button transactionButton;
        private System.Windows.Forms.Label applicationModeLabel;
    }
}

