namespace FONZY
{
	partial class CashierAndEventInfo
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
            this.cashierNameLabel = new System.Windows.Forms.Label();
            this.eventNameLabel = new System.Windows.Forms.Label();
            this.cashierNameTextBox = new System.Windows.Forms.TextBox();
            this.eventNameTextBox = new System.Windows.Forms.TextBox();
            this.cashierAndEventButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cashierNameLabel
            // 
            this.cashierNameLabel.AutoSize = true;
            this.cashierNameLabel.Location = new System.Drawing.Point(12, 20);
            this.cashierNameLabel.Name = "cashierNameLabel";
            this.cashierNameLabel.Size = new System.Drawing.Size(73, 13);
            this.cashierNameLabel.TabIndex = 0;
            this.cashierNameLabel.Text = "Cashier Name";
            // 
            // eventNameLabel
            // 
            this.eventNameLabel.AutoSize = true;
            this.eventNameLabel.Location = new System.Drawing.Point(12, 50);
            this.eventNameLabel.Name = "eventNameLabel";
            this.eventNameLabel.Size = new System.Drawing.Size(66, 13);
            this.eventNameLabel.TabIndex = 1;
            this.eventNameLabel.Text = "Event Name";
            // 
            // cashierNameTextBox
            // 
            this.cashierNameTextBox.Location = new System.Drawing.Point(99, 17);
            this.cashierNameTextBox.Name = "cashierNameTextBox";
            this.cashierNameTextBox.Size = new System.Drawing.Size(181, 20);
            this.cashierNameTextBox.TabIndex = 2;
            // 
            // eventNameTextBox
            // 
            this.eventNameTextBox.Location = new System.Drawing.Point(99, 47);
            this.eventNameTextBox.Name = "eventNameTextBox";
            this.eventNameTextBox.Size = new System.Drawing.Size(181, 20);
            this.eventNameTextBox.TabIndex = 3;
            // 
            // cashierAndEventButton
            // 
            this.cashierAndEventButton.Location = new System.Drawing.Point(115, 75);
            this.cashierAndEventButton.Name = "cashierAndEventButton";
            this.cashierAndEventButton.Size = new System.Drawing.Size(75, 23);
            this.cashierAndEventButton.TabIndex = 4;
            this.cashierAndEventButton.Text = "Proceed";
            this.cashierAndEventButton.UseVisualStyleBackColor = true;
            this.cashierAndEventButton.Click += new System.EventHandler(this.CashierAndEventButton_Click);
            // 
            // CashierAndEventInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 111);
            this.Controls.Add(this.cashierAndEventButton);
            this.Controls.Add(this.eventNameTextBox);
            this.Controls.Add(this.cashierNameTextBox);
            this.Controls.Add(this.eventNameLabel);
            this.Controls.Add(this.cashierNameLabel);
            this.Name = "CashierAndEventInfo";
            this.Text = "Cashier and Event";
            this.ResumeLayout(false);
            this.PerformLayout();

		}

        #endregion

        private System.Windows.Forms.Label cashierNameLabel;
        private System.Windows.Forms.Label eventNameLabel;
        private System.Windows.Forms.TextBox cashierNameTextBox;
        private System.Windows.Forms.TextBox eventNameTextBox;
        private System.Windows.Forms.Button cashierAndEventButton;
    }
}