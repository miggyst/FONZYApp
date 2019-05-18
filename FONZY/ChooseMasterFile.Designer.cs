namespace FONZY
{
	partial class ChooseMasterFile
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
            this.masterFileLabel = new System.Windows.Forms.Label();
            this.masterFileButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // masterFileLabel
            // 
            this.masterFileLabel.AutoSize = true;
            this.masterFileLabel.Location = new System.Drawing.Point(10, 10);
            this.masterFileLabel.Name = "masterFileLabel";
            this.masterFileLabel.Size = new System.Drawing.Size(182, 13);
            this.masterFileLabel.TabIndex = 0;
            this.masterFileLabel.Text = "Please specify the product master file";
            // 
            // masterFileButton
            // 
            this.masterFileButton.Location = new System.Drawing.Point(60, 30);
            this.masterFileButton.Name = "masterFileButton";
            this.masterFileButton.Size = new System.Drawing.Size(75, 23);
            this.masterFileButton.TabIndex = 1;
            this.masterFileButton.Text = "Proceed";
            this.masterFileButton.UseVisualStyleBackColor = true;
            this.masterFileButton.Click += new System.EventHandler(this.MasterFileButton_Click);
            // 
            // ChooseMasterFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(204, 61);
            this.Controls.Add(this.masterFileButton);
            this.Controls.Add(this.masterFileLabel);
            this.Name = "ChooseMasterFile";
            this.Text = "Master File";
            this.ResumeLayout(false);
            this.PerformLayout();

		}

        #endregion

        private System.Windows.Forms.Label masterFileLabel;
        private System.Windows.Forms.Button masterFileButton;
    }
}