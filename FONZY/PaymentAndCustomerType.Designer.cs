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
            this.cancelButton = new System.Windows.Forms.Button();
            this.customerTypeGroupBox = new System.Windows.Forms.GroupBox();
            this.customerTypeNonStatIntern = new System.Windows.Forms.RadioButton();
            this.customerTypeGuest = new System.Windows.Forms.RadioButton();
            this.customerTypeEmployee = new System.Windows.Forms.RadioButton();
            this.customerTypeOld = new System.Windows.Forms.RadioButton();
            this.customerTypeNew = new System.Windows.Forms.RadioButton();
            this.customerTypeGroupBox.SuspendLayout();
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
            this.paymentTypeCheckBox.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.PaymentTypeCheckBox_ItemCheck);
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
            // customerTypeGroupBox
            // 
            this.customerTypeGroupBox.Controls.Add(this.customerTypeNonStatIntern);
            this.customerTypeGroupBox.Controls.Add(this.customerTypeGuest);
            this.customerTypeGroupBox.Controls.Add(this.customerTypeEmployee);
            this.customerTypeGroupBox.Controls.Add(this.customerTypeOld);
            this.customerTypeGroupBox.Controls.Add(this.customerTypeNew);
            this.customerTypeGroupBox.Location = new System.Drawing.Point(12, 36);
            this.customerTypeGroupBox.Name = "customerTypeGroupBox";
            this.customerTypeGroupBox.Size = new System.Drawing.Size(110, 100);
            this.customerTypeGroupBox.TabIndex = 7;
            this.customerTypeGroupBox.TabStop = false;
            // 
            // customerTypeNonStatIntern
            // 
            this.customerTypeNonStatIntern.AutoSize = true;
            this.customerTypeNonStatIntern.Location = new System.Drawing.Point(6, 74);
            this.customerTypeNonStatIntern.Name = "customerTypeNonStatIntern";
            this.customerTypeNonStatIntern.Size = new System.Drawing.Size(97, 17);
            this.customerTypeNonStatIntern.TabIndex = 4;
            this.customerTypeNonStatIntern.Text = "Non-stat/Intern";
            this.customerTypeNonStatIntern.UseVisualStyleBackColor = true;
            // 
            // customerTypeGuest
            // 
            this.customerTypeGuest.AutoSize = true;
            this.customerTypeGuest.Location = new System.Drawing.Point(6, 58);
            this.customerTypeGuest.Name = "customerTypeGuest";
            this.customerTypeGuest.Size = new System.Drawing.Size(53, 17);
            this.customerTypeGuest.TabIndex = 3;
            this.customerTypeGuest.Text = "Guest";
            this.customerTypeGuest.UseVisualStyleBackColor = true;
            // 
            // customerTypeEmployee
            // 
            this.customerTypeEmployee.AutoSize = true;
            this.customerTypeEmployee.Location = new System.Drawing.Point(6, 42);
            this.customerTypeEmployee.Name = "customerTypeEmployee";
            this.customerTypeEmployee.Size = new System.Drawing.Size(71, 17);
            this.customerTypeEmployee.TabIndex = 2;
            this.customerTypeEmployee.Text = "Employee";
            this.customerTypeEmployee.UseVisualStyleBackColor = true;
            // 
            // customerTypeOld
            // 
            this.customerTypeOld.AutoSize = true;
            this.customerTypeOld.Location = new System.Drawing.Point(6, 26);
            this.customerTypeOld.Name = "customerTypeOld";
            this.customerTypeOld.Size = new System.Drawing.Size(41, 17);
            this.customerTypeOld.TabIndex = 1;
            this.customerTypeOld.Text = "Old";
            this.customerTypeOld.UseVisualStyleBackColor = true;
            // 
            // customerTypeNew
            // 
            this.customerTypeNew.AutoSize = true;
            this.customerTypeNew.Checked = true;
            this.customerTypeNew.Cursor = System.Windows.Forms.Cursors.Default;
            this.customerTypeNew.Location = new System.Drawing.Point(6, 10);
            this.customerTypeNew.Name = "customerTypeNew";
            this.customerTypeNew.Size = new System.Drawing.Size(47, 17);
            this.customerTypeNew.TabIndex = 0;
            this.customerTypeNew.TabStop = true;
            this.customerTypeNew.Text = "New";
            this.customerTypeNew.UseVisualStyleBackColor = true;
            // 
            // PaymentAndCustomerType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 181);
            this.Controls.Add(this.customerTypeGroupBox);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.customerTypeLabel);
            this.Controls.Add(this.paymentTypeLabel);
            this.Controls.Add(this.paymentAndCustomerTypeButton);
            this.Controls.Add(this.paymentTypeCheckBox);
            this.Name = "PaymentAndCustomerType";
            this.Text = "Payment and Customer Type";
            this.Load += new System.EventHandler(this.PaymentAndCustomerType_Load);
            this.customerTypeGroupBox.ResumeLayout(false);
            this.customerTypeGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

        #endregion

        private System.Windows.Forms.CheckedListBox paymentTypeCheckBox;
        private System.Windows.Forms.Button paymentAndCustomerTypeButton;
        private System.Windows.Forms.Label paymentTypeLabel;
        private System.Windows.Forms.Label customerTypeLabel;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.GroupBox customerTypeGroupBox;
        private System.Windows.Forms.RadioButton customerTypeEmployee;
        private System.Windows.Forms.RadioButton customerTypeOld;
        private System.Windows.Forms.RadioButton customerTypeNew;
        private System.Windows.Forms.RadioButton customerTypeNonStatIntern;
        private System.Windows.Forms.RadioButton customerTypeGuest;
    }
}