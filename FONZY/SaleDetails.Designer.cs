namespace FONZY
{
	partial class SaleDetails
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
            this.addProductButton = new System.Windows.Forms.Button();
            this.nameLabel = new System.Windows.Forms.Label();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.addressLabel = new System.Windows.Forms.Label();
            this.totalQuantityLabel = new System.Windows.Forms.Label();
            this.totalCostLabel = new System.Windows.Forms.Label();
            this.productBarCodeLabel = new System.Windows.Forms.Label();
            this.quantityLabel = new System.Windows.Forms.Label();
            this.processButton = new System.Windows.Forms.Button();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.totalQuantityTextBox = new System.Windows.Forms.TextBox();
            this.totalCostTextBox = new System.Windows.Forms.TextBox();
            this.productBarCodeTextBox = new System.Windows.Forms.TextBox();
            this.productOrderDataGridView = new System.Windows.Forms.DataGridView();
            this.barCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.discount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityNumericUpDown = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.productOrderDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quantityNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // addProductButton
            // 
            this.addProductButton.Location = new System.Drawing.Point(551, 596);
            this.addProductButton.Name = "addProductButton";
            this.addProductButton.Size = new System.Drawing.Size(110, 23);
            this.addProductButton.TabIndex = 0;
            this.addProductButton.Text = "Add";
            this.addProductButton.UseVisualStyleBackColor = true;
            this.addProductButton.Click += new System.EventHandler(this.AddProductButton_Click);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(20, 15);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(35, 13);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.Text = "Name";
            // 
            // phoneLabel
            // 
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.Location = new System.Drawing.Point(478, 15);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(38, 13);
            this.phoneLabel.TabIndex = 2;
            this.phoneLabel.Text = "Phone";
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Location = new System.Drawing.Point(20, 42);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(45, 13);
            this.addressLabel.TabIndex = 3;
            this.addressLabel.Text = "Address";
            // 
            // totalQuantityLabel
            // 
            this.totalQuantityLabel.AutoSize = true;
            this.totalQuantityLabel.Location = new System.Drawing.Point(20, 563);
            this.totalQuantityLabel.Name = "totalQuantityLabel";
            this.totalQuantityLabel.Size = new System.Drawing.Size(73, 13);
            this.totalQuantityLabel.TabIndex = 4;
            this.totalQuantityLabel.Text = "Total Quantity";
            // 
            // totalCostLabel
            // 
            this.totalCostLabel.AutoSize = true;
            this.totalCostLabel.Location = new System.Drawing.Point(504, 563);
            this.totalCostLabel.Name = "totalCostLabel";
            this.totalCostLabel.Size = new System.Drawing.Size(55, 13);
            this.totalCostLabel.TabIndex = 5;
            this.totalCostLabel.Text = "Total Cost";
            // 
            // productBarCodeLabel
            // 
            this.productBarCodeLabel.AutoSize = true;
            this.productBarCodeLabel.Location = new System.Drawing.Point(20, 601);
            this.productBarCodeLabel.Name = "productBarCodeLabel";
            this.productBarCodeLabel.Size = new System.Drawing.Size(91, 13);
            this.productBarCodeLabel.TabIndex = 6;
            this.productBarCodeLabel.Text = "Product Bar Code";
            // 
            // quantityLabel
            // 
            this.quantityLabel.AutoSize = true;
            this.quantityLabel.Location = new System.Drawing.Point(416, 601);
            this.quantityLabel.Name = "quantityLabel";
            this.quantityLabel.Size = new System.Drawing.Size(46, 13);
            this.quantityLabel.TabIndex = 7;
            this.quantityLabel.Text = "Quantity";
            // 
            // processButton
            // 
            this.processButton.Location = new System.Drawing.Point(300, 625);
            this.processButton.Name = "processButton";
            this.processButton.Size = new System.Drawing.Size(75, 23);
            this.processButton.TabIndex = 8;
            this.processButton.Text = "PROCESS";
            this.processButton.UseVisualStyleBackColor = true;
            this.processButton.Click += new System.EventHandler(this.ProcessButton_Click);
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(84, 12);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(369, 20);
            this.nameTextBox.TabIndex = 9;
            this.nameTextBox.TextChanged += new System.EventHandler(this.NameTextBox_TextChanged);
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.Location = new System.Drawing.Point(522, 12);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(139, 20);
            this.phoneTextBox.TabIndex = 10;
            this.phoneTextBox.TextChanged += new System.EventHandler(this.PhoneTextBox_TextChanged);
            // 
            // addressTextBox
            // 
            this.addressTextBox.Location = new System.Drawing.Point(84, 39);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(577, 20);
            this.addressTextBox.TabIndex = 11;
            this.addressTextBox.TextChanged += new System.EventHandler(this.AddressTextBox_TextChanged);
            // 
            // totalQuantityTextBox
            // 
            this.totalQuantityTextBox.Location = new System.Drawing.Point(99, 560);
            this.totalQuantityTextBox.Name = "totalQuantityTextBox";
            this.totalQuantityTextBox.ReadOnly = true;
            this.totalQuantityTextBox.Size = new System.Drawing.Size(100, 20);
            this.totalQuantityTextBox.TabIndex = 12;
            // 
            // totalCostTextBox
            // 
            this.totalCostTextBox.Location = new System.Drawing.Point(565, 560);
            this.totalCostTextBox.Name = "totalCostTextBox";
            this.totalCostTextBox.ReadOnly = true;
            this.totalCostTextBox.Size = new System.Drawing.Size(96, 20);
            this.totalCostTextBox.TabIndex = 13;
            // 
            // productBarCodeTextBox
            // 
            this.productBarCodeTextBox.Location = new System.Drawing.Point(117, 598);
            this.productBarCodeTextBox.Name = "productBarCodeTextBox";
            this.productBarCodeTextBox.Size = new System.Drawing.Size(263, 20);
            this.productBarCodeTextBox.TabIndex = 15;
            // 
            // productOrderDataGridView
            // 
            this.productOrderDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productOrderDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.barCode,
            this.productDescription,
            this.price,
            this.quantity,
            this.discount,
            this.amount});
            this.productOrderDataGridView.Location = new System.Drawing.Point(23, 65);
            this.productOrderDataGridView.Name = "productOrderDataGridView";
            this.productOrderDataGridView.Size = new System.Drawing.Size(638, 495);
            this.productOrderDataGridView.TabIndex = 16;
            this.productOrderDataGridView.TabIndexChanged += new System.EventHandler(this.ProductOrderDataGridView_TabIndexChanged);
            // 
            // barCode
            // 
            this.barCode.HeaderText = "Bar Code";
            this.barCode.Name = "barCode";
            this.barCode.ReadOnly = true;
            this.barCode.Width = 95;
            // 
            // productDescription
            // 
            this.productDescription.HeaderText = "Product Description";
            this.productDescription.Name = "productDescription";
            this.productDescription.ReadOnly = true;
            this.productDescription.Width = 200;
            // 
            // price
            // 
            this.price.HeaderText = "Price";
            this.price.Name = "price";
            this.price.ReadOnly = true;
            this.price.Width = 80;
            // 
            // quantity
            // 
            this.quantity.HeaderText = "Quantity";
            this.quantity.Name = "quantity";
            this.quantity.ReadOnly = true;
            this.quantity.Width = 60;
            // 
            // discount
            // 
            this.discount.HeaderText = "Discount";
            this.discount.Name = "discount";
            this.discount.ReadOnly = true;
            this.discount.Width = 60;
            // 
            // amount
            // 
            this.amount.HeaderText = "Amount";
            this.amount.Name = "amount";
            this.amount.ReadOnly = true;
            // 
            // quantityNumericUpDown
            // 
            this.quantityNumericUpDown.Location = new System.Drawing.Point(466, 599);
            this.quantityNumericUpDown.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.quantityNumericUpDown.Minimum = new decimal(new int[] {
            9999999,
            0,
            0,
            -2147483648});
            this.quantityNumericUpDown.Name = "quantityNumericUpDown";
            this.quantityNumericUpDown.Size = new System.Drawing.Size(50, 20);
            this.quantityNumericUpDown.TabIndex = 17;
            this.quantityNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // SaleDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 661);
            this.Controls.Add(this.quantityNumericUpDown);
            this.Controls.Add(this.productOrderDataGridView);
            this.Controls.Add(this.productBarCodeTextBox);
            this.Controls.Add(this.totalCostTextBox);
            this.Controls.Add(this.totalQuantityTextBox);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(this.phoneTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.processButton);
            this.Controls.Add(this.quantityLabel);
            this.Controls.Add(this.productBarCodeLabel);
            this.Controls.Add(this.totalCostLabel);
            this.Controls.Add(this.totalQuantityLabel);
            this.Controls.Add(this.addressLabel);
            this.Controls.Add(this.phoneLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.addProductButton);
            this.Name = "SaleDetails";
            this.Text = "Sale Details";
            this.Load += new System.EventHandler(this.SaleDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productOrderDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quantityNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

        #endregion

        private System.Windows.Forms.Button addProductButton;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label phoneLabel;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.Label totalQuantityLabel;
        private System.Windows.Forms.Label totalCostLabel;
        private System.Windows.Forms.Label productBarCodeLabel;
        private System.Windows.Forms.Label quantityLabel;
        private System.Windows.Forms.Button processButton;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.TextBox totalQuantityTextBox;
        private System.Windows.Forms.TextBox totalCostTextBox;
        private System.Windows.Forms.TextBox productBarCodeTextBox;
        private System.Windows.Forms.DataGridView productOrderDataGridView;
        private System.Windows.Forms.NumericUpDown quantityNumericUpDown;
        private System.Windows.Forms.DataGridViewTextBoxColumn barCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn productDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn discount;
        private System.Windows.Forms.DataGridViewTextBoxColumn amount;
    }
}