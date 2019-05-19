namespace FONZY
{
	partial class PrinterDetails
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
            this.printerLabel = new System.Windows.Forms.Label();
            this.printButton = new System.Windows.Forms.Button();
            this.openButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // printerLabel
            // 
            this.printerLabel.AutoSize = true;
            this.printerLabel.Location = new System.Drawing.Point(12, 19);
            this.printerLabel.Name = "printerLabel";
            this.printerLabel.Size = new System.Drawing.Size(273, 13);
            this.printerLabel.TabIndex = 0;
            this.printerLabel.Text = "Please choose how you would like to print the document";
            // 
            // printButton
            // 
            this.printButton.Location = new System.Drawing.Point(10, 45);
            this.printButton.Name = "printButton";
            this.printButton.Size = new System.Drawing.Size(75, 23);
            this.printButton.TabIndex = 1;
            this.printButton.Text = "Print";
            this.printButton.UseVisualStyleBackColor = true;
            this.printButton.Click += new System.EventHandler(this.PrintButton_Click);
            // 
            // openButton
            // 
            this.openButton.Location = new System.Drawing.Point(110, 45);
            this.openButton.Name = "openButton";
            this.openButton.Size = new System.Drawing.Size(75, 23);
            this.openButton.TabIndex = 2;
            this.openButton.Text = "Open";
            this.openButton.UseVisualStyleBackColor = true;
            this.openButton.Click += new System.EventHandler(this.OpenButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(210, 45);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 3;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // PrinterDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 81);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.openButton);
            this.Controls.Add(this.printButton);
            this.Controls.Add(this.printerLabel);
            this.Name = "PrinterDetails";
            this.Text = "Printer";
            this.ResumeLayout(false);
            this.PerformLayout();

		}

        #endregion

        private System.Windows.Forms.Label printerLabel;
        private System.Windows.Forms.Button printButton;
        private System.Windows.Forms.Button openButton;
        private System.Windows.Forms.Button cancelButton;
    }
}