namespace FONZY
{
	partial class PaymentCalculator
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
            this.totalAmountLabel = new System.Windows.Forms.Label();
            this.cashLabel = new System.Windows.Forms.Label();
            this.creditLabel = new System.Windows.Forms.Label();
            this.debitLabel = new System.Windows.Forms.Label();
            this.checkLabel = new System.Windows.Forms.Label();
            this.salaryDeductionLabel = new System.Windows.Forms.Label();
            this.totalCustomerPaymentLabel = new System.Windows.Forms.Label();
            this.changeLabel = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.proceedButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.totalAmountTextBox = new System.Windows.Forms.TextBox();
            this.cashTextBox = new System.Windows.Forms.TextBox();
            this.creditTextBox = new System.Windows.Forms.TextBox();
            this.debitTextBox = new System.Windows.Forms.TextBox();
            this.checkTextBox = new System.Windows.Forms.TextBox();
            this.salaryDeductionTextBox = new System.Windows.Forms.TextBox();
            this.totalCustomerPaymentTextBox = new System.Windows.Forms.TextBox();
            this.changeTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // totalAmountLabel
            // 
            this.totalAmountLabel.AutoSize = true;
            this.totalAmountLabel.Location = new System.Drawing.Point(25, 25);
            this.totalAmountLabel.Name = "totalAmountLabel";
            this.totalAmountLabel.Size = new System.Drawing.Size(70, 13);
            this.totalAmountLabel.TabIndex = 0;
            this.totalAmountLabel.Text = "Total Amount";
            // 
            // cashLabel
            // 
            this.cashLabel.AutoSize = true;
            this.cashLabel.Location = new System.Drawing.Point(25, 50);
            this.cashLabel.Name = "cashLabel";
            this.cashLabel.Size = new System.Drawing.Size(31, 13);
            this.cashLabel.TabIndex = 1;
            this.cashLabel.Text = "Cash";
            // 
            // creditLabel
            // 
            this.creditLabel.AutoSize = true;
            this.creditLabel.Location = new System.Drawing.Point(25, 75);
            this.creditLabel.Name = "creditLabel";
            this.creditLabel.Size = new System.Drawing.Size(34, 13);
            this.creditLabel.TabIndex = 2;
            this.creditLabel.Text = "Credit";
            // 
            // debitLabel
            // 
            this.debitLabel.AutoSize = true;
            this.debitLabel.Location = new System.Drawing.Point(24, 100);
            this.debitLabel.Name = "debitLabel";
            this.debitLabel.Size = new System.Drawing.Size(32, 13);
            this.debitLabel.TabIndex = 3;
            this.debitLabel.Text = "Debit";
            // 
            // checkLabel
            // 
            this.checkLabel.AutoSize = true;
            this.checkLabel.Location = new System.Drawing.Point(25, 125);
            this.checkLabel.Name = "checkLabel";
            this.checkLabel.Size = new System.Drawing.Size(38, 13);
            this.checkLabel.TabIndex = 4;
            this.checkLabel.Text = "Check";
            // 
            // salaryDeductionLabel
            // 
            this.salaryDeductionLabel.AutoSize = true;
            this.salaryDeductionLabel.Location = new System.Drawing.Point(24, 150);
            this.salaryDeductionLabel.Name = "salaryDeductionLabel";
            this.salaryDeductionLabel.Size = new System.Drawing.Size(88, 13);
            this.salaryDeductionLabel.TabIndex = 5;
            this.salaryDeductionLabel.Text = "Salary Deduction";
            // 
            // totalCustomerPaymentLabel
            // 
            this.totalCustomerPaymentLabel.AutoSize = true;
            this.totalCustomerPaymentLabel.Location = new System.Drawing.Point(59, 181);
            this.totalCustomerPaymentLabel.Name = "totalCustomerPaymentLabel";
            this.totalCustomerPaymentLabel.Size = new System.Drawing.Size(122, 13);
            this.totalCustomerPaymentLabel.TabIndex = 6;
            this.totalCustomerPaymentLabel.Text = "Total Customer Payment";
            // 
            // changeLabel
            // 
            this.changeLabel.AutoSize = true;
            this.changeLabel.Location = new System.Drawing.Point(93, 229);
            this.changeLabel.Name = "changeLabel";
            this.changeLabel.Size = new System.Drawing.Size(44, 13);
            this.changeLabel.TabIndex = 7;
            this.changeLabel.Text = "Change";
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(78, 275);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(75, 23);
            this.calculateButton.TabIndex = 8;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            // 
            // proceedButton
            // 
            this.proceedButton.Location = new System.Drawing.Point(27, 307);
            this.proceedButton.Name = "proceedButton";
            this.proceedButton.Size = new System.Drawing.Size(75, 23);
            this.proceedButton.TabIndex = 9;
            this.proceedButton.Text = "Proceed";
            this.proceedButton.UseVisualStyleBackColor = true;
            this.proceedButton.Click += new System.EventHandler(this.ProceedButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(139, 307);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 10;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // totalAmountTextBox
            // 
            this.totalAmountTextBox.Location = new System.Drawing.Point(114, 22);
            this.totalAmountTextBox.Name = "totalAmountTextBox";
            this.totalAmountTextBox.ReadOnly = true;
            this.totalAmountTextBox.Size = new System.Drawing.Size(100, 20);
            this.totalAmountTextBox.TabIndex = 11;
            this.totalAmountTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // cashTextBox
            // 
            this.cashTextBox.Location = new System.Drawing.Point(114, 47);
            this.cashTextBox.Name = "cashTextBox";
            this.cashTextBox.Size = new System.Drawing.Size(100, 20);
            this.cashTextBox.TabIndex = 12;
            this.cashTextBox.Text = "0";
            this.cashTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.cashTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CashTextBox_KeyPress);
            // 
            // creditTextBox
            // 
            this.creditTextBox.Location = new System.Drawing.Point(114, 72);
            this.creditTextBox.Name = "creditTextBox";
            this.creditTextBox.Size = new System.Drawing.Size(100, 20);
            this.creditTextBox.TabIndex = 13;
            this.creditTextBox.Text = "0";
            this.creditTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.creditTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CreditTextBox_KeyPress);
            // 
            // debitTextBox
            // 
            this.debitTextBox.Location = new System.Drawing.Point(114, 97);
            this.debitTextBox.Name = "debitTextBox";
            this.debitTextBox.Size = new System.Drawing.Size(100, 20);
            this.debitTextBox.TabIndex = 14;
            this.debitTextBox.Text = "0";
            this.debitTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.debitTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DebitTextBox_KeyPress);
            // 
            // checkTextBox
            // 
            this.checkTextBox.Location = new System.Drawing.Point(114, 122);
            this.checkTextBox.Name = "checkTextBox";
            this.checkTextBox.Size = new System.Drawing.Size(100, 20);
            this.checkTextBox.TabIndex = 15;
            this.checkTextBox.Text = "0";
            this.checkTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.checkTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CheckTextBox_KeyPress);
            // 
            // salaryDeductionTextBox
            // 
            this.salaryDeductionTextBox.Location = new System.Drawing.Point(114, 147);
            this.salaryDeductionTextBox.Name = "salaryDeductionTextBox";
            this.salaryDeductionTextBox.Size = new System.Drawing.Size(100, 20);
            this.salaryDeductionTextBox.TabIndex = 16;
            this.salaryDeductionTextBox.Text = "0";
            this.salaryDeductionTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.salaryDeductionTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SalaryDeductionTextBox_KeyPress);
            // 
            // totalCustomerPaymentTextBox
            // 
            this.totalCustomerPaymentTextBox.Location = new System.Drawing.Point(27, 197);
            this.totalCustomerPaymentTextBox.Name = "totalCustomerPaymentTextBox";
            this.totalCustomerPaymentTextBox.ReadOnly = true;
            this.totalCustomerPaymentTextBox.Size = new System.Drawing.Size(187, 20);
            this.totalCustomerPaymentTextBox.TabIndex = 17;
            this.totalCustomerPaymentTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // changeTextBox
            // 
            this.changeTextBox.Location = new System.Drawing.Point(28, 245);
            this.changeTextBox.Name = "changeTextBox";
            this.changeTextBox.ReadOnly = true;
            this.changeTextBox.Size = new System.Drawing.Size(186, 20);
            this.changeTextBox.TabIndex = 18;
            this.changeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // PaymentCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(239, 341);
            this.Controls.Add(this.changeTextBox);
            this.Controls.Add(this.totalCustomerPaymentTextBox);
            this.Controls.Add(this.salaryDeductionTextBox);
            this.Controls.Add(this.checkTextBox);
            this.Controls.Add(this.debitTextBox);
            this.Controls.Add(this.creditTextBox);
            this.Controls.Add(this.cashTextBox);
            this.Controls.Add(this.totalAmountTextBox);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.proceedButton);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.changeLabel);
            this.Controls.Add(this.totalCustomerPaymentLabel);
            this.Controls.Add(this.salaryDeductionLabel);
            this.Controls.Add(this.checkLabel);
            this.Controls.Add(this.debitLabel);
            this.Controls.Add(this.creditLabel);
            this.Controls.Add(this.cashLabel);
            this.Controls.Add(this.totalAmountLabel);
            this.Name = "PaymentCalculator";
            this.Text = "Payment Calculator";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PaymentCalculator_FormClosing);
            this.Load += new System.EventHandler(this.PaymentCalculator_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

        #endregion

        private System.Windows.Forms.Label totalAmountLabel;
        private System.Windows.Forms.Label cashLabel;
        private System.Windows.Forms.Label creditLabel;
        private System.Windows.Forms.Label debitLabel;
        private System.Windows.Forms.Label checkLabel;
        private System.Windows.Forms.Label salaryDeductionLabel;
        private System.Windows.Forms.Label totalCustomerPaymentLabel;
        private System.Windows.Forms.Label changeLabel;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button proceedButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.TextBox totalAmountTextBox;
        private System.Windows.Forms.TextBox cashTextBox;
        private System.Windows.Forms.TextBox creditTextBox;
        private System.Windows.Forms.TextBox debitTextBox;
        private System.Windows.Forms.TextBox checkTextBox;
        private System.Windows.Forms.TextBox salaryDeductionTextBox;
        private System.Windows.Forms.TextBox totalCustomerPaymentTextBox;
        private System.Windows.Forms.TextBox changeTextBox;
    }
}