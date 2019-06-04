namespace FONZY
{
    partial class InventorySaleDetails
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
            this.productOrderDataGridView = new System.Windows.Forms.DataGridView();
            this.barCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.discount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.productBarCodeTextBox = new System.Windows.Forms.TextBox();
            this.processButton = new System.Windows.Forms.Button();
            this.quantityLabel = new System.Windows.Forms.Label();
            this.productBarCodeLabel = new System.Windows.Forms.Label();
            this.addProductButton = new System.Windows.Forms.Button();
            this.totalQuantityTextBox = new System.Windows.Forms.TextBox();
            this.totalQuantityLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.productOrderDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quantityNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // productOrderDataGridView
            // 
            this.productOrderDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productOrderDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.barCode,
            this.productDescription,
            this.price,
            this.quantity,
            this.discount});
            this.productOrderDataGridView.Location = new System.Drawing.Point(22, 12);
            this.productOrderDataGridView.Name = "productOrderDataGridView";
            this.productOrderDataGridView.Size = new System.Drawing.Size(638, 557);
            this.productOrderDataGridView.TabIndex = 17;
            // 
            // barCode
            // 
            this.barCode.HeaderText = "Bar Code";
            this.barCode.Name = "barCode";
            this.barCode.ReadOnly = true;
            // 
            // productDescription
            // 
            this.productDescription.HeaderText = "Product Description";
            this.productDescription.Name = "productDescription";
            this.productDescription.ReadOnly = true;
            this.productDescription.Width = 295;
            // 
            // price
            // 
            this.price.HeaderText = "Price";
            this.price.Name = "price";
            this.price.ReadOnly = true;
            this.price.Width = 70;
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
            this.discount.Width = 50;
            // 
            // quantityNumericUpDown
            // 
            this.quantityNumericUpDown.Location = new System.Drawing.Point(465, 606);
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
            this.quantityNumericUpDown.TabIndex = 23;
            this.quantityNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.quantityNumericUpDown.KeyDown += new System.Windows.Forms.KeyEventHandler(this.QuantityNumericUpDown_KeyDown);
            // 
            // productBarCodeTextBox
            // 
            this.productBarCodeTextBox.Location = new System.Drawing.Point(116, 605);
            this.productBarCodeTextBox.Name = "productBarCodeTextBox";
            this.productBarCodeTextBox.Size = new System.Drawing.Size(263, 20);
            this.productBarCodeTextBox.TabIndex = 22;
            this.productBarCodeTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ProductBarCodeTextBox_KeyDown);
            // 
            // processButton
            // 
            this.processButton.Location = new System.Drawing.Point(280, 630);
            this.processButton.Name = "processButton";
            this.processButton.Size = new System.Drawing.Size(97, 23);
            this.processButton.TabIndex = 21;
            this.processButton.Text = "PROCESS";
            this.processButton.UseVisualStyleBackColor = true;
            this.processButton.Click += new System.EventHandler(this.ProcessButton_Click);
            // 
            // quantityLabel
            // 
            this.quantityLabel.AutoSize = true;
            this.quantityLabel.Location = new System.Drawing.Point(415, 608);
            this.quantityLabel.Name = "quantityLabel";
            this.quantityLabel.Size = new System.Drawing.Size(46, 13);
            this.quantityLabel.TabIndex = 20;
            this.quantityLabel.Text = "Quantity";
            // 
            // productBarCodeLabel
            // 
            this.productBarCodeLabel.AutoSize = true;
            this.productBarCodeLabel.Location = new System.Drawing.Point(19, 608);
            this.productBarCodeLabel.Name = "productBarCodeLabel";
            this.productBarCodeLabel.Size = new System.Drawing.Size(91, 13);
            this.productBarCodeLabel.TabIndex = 19;
            this.productBarCodeLabel.Text = "Product Bar Code";
            // 
            // addProductButton
            // 
            this.addProductButton.Location = new System.Drawing.Point(550, 603);
            this.addProductButton.Name = "addProductButton";
            this.addProductButton.Size = new System.Drawing.Size(110, 23);
            this.addProductButton.TabIndex = 18;
            this.addProductButton.Text = "Add";
            this.addProductButton.UseVisualStyleBackColor = true;
            this.addProductButton.Click += new System.EventHandler(this.AddProductButton_Click);
            // 
            // totalQuantityTextBox
            // 
            this.totalQuantityTextBox.Location = new System.Drawing.Point(560, 569);
            this.totalQuantityTextBox.Name = "totalQuantityTextBox";
            this.totalQuantityTextBox.ReadOnly = true;
            this.totalQuantityTextBox.Size = new System.Drawing.Size(100, 20);
            this.totalQuantityTextBox.TabIndex = 25;
            // 
            // totalQuantityLabel
            // 
            this.totalQuantityLabel.AutoSize = true;
            this.totalQuantityLabel.Location = new System.Drawing.Point(481, 572);
            this.totalQuantityLabel.Name = "totalQuantityLabel";
            this.totalQuantityLabel.Size = new System.Drawing.Size(73, 13);
            this.totalQuantityLabel.TabIndex = 24;
            this.totalQuantityLabel.Text = "Total Quantity";
            // 
            // InventorySaleDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 661);
            this.Controls.Add(this.totalQuantityTextBox);
            this.Controls.Add(this.totalQuantityLabel);
            this.Controls.Add(this.quantityNumericUpDown);
            this.Controls.Add(this.productBarCodeTextBox);
            this.Controls.Add(this.processButton);
            this.Controls.Add(this.quantityLabel);
            this.Controls.Add(this.productBarCodeLabel);
            this.Controls.Add(this.addProductButton);
            this.Controls.Add(this.productOrderDataGridView);
            this.Name = "InventorySaleDetails";
            this.Text = "InventorySaleDetails";
            this.Load += new System.EventHandler(this.InventorySaleDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productOrderDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quantityNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView productOrderDataGridView;
        private System.Windows.Forms.NumericUpDown quantityNumericUpDown;
        private System.Windows.Forms.TextBox productBarCodeTextBox;
        private System.Windows.Forms.Button processButton;
        private System.Windows.Forms.Label quantityLabel;
        private System.Windows.Forms.Label productBarCodeLabel;
        private System.Windows.Forms.Button addProductButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn barCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn productDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn discount;
        private System.Windows.Forms.TextBox totalQuantityTextBox;
        private System.Windows.Forms.Label totalQuantityLabel;
    }
}