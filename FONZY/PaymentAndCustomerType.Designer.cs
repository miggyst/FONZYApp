namespace FONZY
{
	partial class PaymentAndCustomerType
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
            this.paymentTypeCheckBox = new System.Windows.Forms.CheckedListBox();
            this.paymentAndCustomerTypeButton = new System.Windows.Forms.Button();
            this.paymentTypeLabel = new System.Windows.Forms.Label();
            this.customerTypeLabel = new System.Windows.Forms.Label();
            this.customerTypeCheckBox = new System.Windows.Forms.CheckedListBox();
            this.cancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // paymentTypeCheckBox
            // 
            this.paymentTypeCheckBox.FormattingEnabled = true;
            this.paymentTypeCheckBox.Items.AddRange(new object[] {
            "Cash",
            "Credit",
            "Debit",
            "Check",
            "Salary Deduction"});
            this.paymentTypeCheckBox.Location = new System.Drawing.Point(158, 46);
            this.paymentTypeCheckBox.Name = "paymentTypeCheckBox";
            this.paymentTypeCheckBox.Size = new System.Drawing.Size(110, 79);
            this.paymentTypeCheckBox.TabIndex = 0;
            // 
            // paymentAndCustomerTypeButton
            // 
            this.paymentAndCustomerTypeButton.Location = new System.Drawing.Point(47, 142);
            this.paymentAndCustomerTypeButton.Name = "paymentAndCustomerTypeButton";
            this.paymentAndCustomerTypeButton.Size = new System.Drawing.Size(75, 23);
            this.paymentAndCustomerTypeButton.TabIndex = 1;
            this.paymentAndCustomerTypeButton.Text = "Proceed";
            this.paymentAndCustomerTypeButton.UseVisualStyleBackColor = true;
            this.paymentAndCustomerTypeButton.Click += new System.EventHandler(this.PaymentAndCustomerTypeButton_Click);
            // 
            // paymentTypeLabel
            // 
            this.paymentTypeLabel.AutoSize = true;
            this.paymentTypeLabel.Location = new System.Drawing.Point(175, 20);
            this.paymentTypeLabel.Name = "paymentTypeLabel";
            this.paymentTypeLabel.Size = new System.Drawing.Size(75, 13);
            this.paymentTypeLabel.TabIndex = 2;
            this.paymentTypeLabel.Text = "Payment Type";
            // 
            // customerTypeLabel
            // 
            this.customerTypeLabel.AutoSize = true;
            this.customerTypeLabel.Location = new System.Drawing.Point(30, 20);
            this.customerTypeLabel.Name = "customerTypeLabel";
            this.customerTypeLabel.Size = new System.Drawing.Size(78, 13);
            this.customerTypeLabel.TabIndex = 3;
            this.customerTypeLabel.Text = "Customer Type";
            // 
            // customerTypeCheckBox
            // 
            this.customerTypeCheckBox.FormattingEnabled = true;
            this.customerTypeCheckBox.Items.AddRange(new object[] {
            "New",
            "Old",
            "Employee",
            "Guest",
            "Non-stat/Intern"});
            this.customerTypeCheckBox.Location = new System.Drawing.Point(12, 46);
            this.customerTypeCheckBox.Name = "customerTypeCheckBox";
            this.customerTypeCheckBox.Size = new System.Drawing.Size(110, 79);
            this.customerTypeCheckBox.TabIndex = 4;
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(158, 142);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 5;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // PaymentAndCustomerType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 181);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.customerTypeCheckBox);
            this.Controls.Add(this.customerTypeLabel);
            this.Controls.Add(this.paymentTypeLabel);
            this.Controls.Add(this.paymentAndCustomerTypeButton);
            this.Controls.Add(this.paymentTypeCheckBox);
            this.Name = "PaymentAndCustomerType";
            this.Text = "Payment and Customer Type";
            this.ResumeLayout(false);
            this.PerformLayout();

		}

        #endregion

        private System.Windows.Forms.CheckedListBox paymentTypeCheckBox;
        private System.Windows.Forms.Button paymentAndCustomerTypeButton;
        private System.Windows.Forms.Label paymentTypeLabel;
        private System.Windows.Forms.Label customerTypeLabel;
        private System.Windows.Forms.CheckedListBox customerTypeCheckBox;
        private System.Windows.Forms.Button cancelButton;
    }
}