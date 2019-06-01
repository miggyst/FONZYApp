using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FONZY
{
    public partial class InventorySaleDetails : Form
    {
        public InventorySaleDetails()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Loads masterListDictionary on Form load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void InventorySaleDetails_Load(object sender, EventArgs e)
        {
            List<string> keyList = new List<string>(GlobalUtilities.getMasterListDictionary().Keys);

            //GlobalUtilities.setTotalQuantity((Int32.Parse(GlobalUtilities.getTotalQuantity()) + Int32.Parse(quantityNumericUpDown.Value.ToString())).ToString());

            for (int i = 0; i < keyList.Count; i++)
            {
                if (!Regex.IsMatch(keyList[i].Replace(" ", ""), @"^[a-zA-Z]+$"))
                {
                    List<string> customerProductOrder = new List<string>(GlobalUtilities.getProductInfoFromDictionary(GlobalUtilities.MASTER, keyList[i]));
                    //                                 Bar Code     Product Description             Price                 Quantity                  Discount
                    productOrderDataGridView.Rows.Add(keyList[i], customerProductOrder[1], customerProductOrder[2], customerProductOrder[3], customerProductOrder[4]);
                }
            }
        }

        /// <summary>
        /// Increases/Decreases the quantity value of the product in the masterListDictionary
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddProductButton_Click(object sender, EventArgs e)
        {
            List<string> customerProductOrder = new List<string>();
            List<string> masterListDictionaryProduct = new List<string>(GlobalUtilities.getMasterListDictionary()[(productBarCodeTextBox.Text).TrimStart(new Char[] { '0' })]);
            DataGridViewRow updateDataGridViewRow = productOrderDataGridView.Rows[rowSearchWithMatchingBarCodes((productBarCodeTextBox.Text).TrimStart(new Char[] { '0' }))];
            int totalQuantityCheck = Int32.Parse(updateDataGridViewRow.Cells[3].Value.ToString()) + (int)quantityNumericUpDown.Value;

            if (totalQuantityCheck <= 0)
            {
                GlobalUtilities.setTotalQuantity((Int32.Parse(GlobalUtilities.getTotalQuantity()) - Int32.Parse(updateDataGridViewRow.Cells[3].Value.ToString())).ToString());

                totalQuantityTextBox.Text = GlobalUtilities.getTotalQuantity();
                updateDataGridViewRow.Cells[3].Value = "0";
                productBarCodeTextBox.Focus();
                quantityNumericUpDown.Value = 1;
                productBarCodeTextBox.Text = "";

                return;
            }

            GlobalUtilities.setTotalQuantity((Int32.Parse(GlobalUtilities.getTotalQuantity()) + Int32.Parse(quantityNumericUpDown.Value.ToString())).ToString());

            updateDataGridViewRow.Cells[3].Value = totalQuantityCheck;
            
            // Material #, Material Description, Selling Price, Discount, and Quantity
            customerProductOrder.Add(masterListDictionaryProduct[0].ToString());
            customerProductOrder.Add(masterListDictionaryProduct[1].ToString());
            customerProductOrder.Add(masterListDictionaryProduct[2].ToString());
            customerProductOrder.Add(masterListDictionaryProduct[3].ToString());
            customerProductOrder.Add(updateDataGridViewRow.Cells[3].Value.ToString());

            foreach(string valString in customerProductOrder)
            {
                Console.WriteLine(valString);
            }
            GlobalUtilities.addToDictionary(GlobalUtilities.MASTER, productBarCodeTextBox.Text, customerProductOrder);

            totalQuantityTextBox.Text = GlobalUtilities.getTotalQuantity();
            productBarCodeTextBox.Focus();
            productBarCodeTextBox.Text = "";
            quantityNumericUpDown.Value = 1;
        }

        /// <summary>
        /// Updates Excel sheet and closes the application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ProcessButton_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        /// <summary>
        /// Searches the DataGridView to find the row with matching bar codes
        /// </summary>
        /// <param name="userInputBarCode"></param>
        private int rowSearchWithMatchingBarCodes(string userInputBarCode)
        {
            foreach (DataGridViewRow row in productOrderDataGridView.Rows)
            {
                if (row.Cells[0].Value.ToString().Equals(userInputBarCode))
                {
                    return row.Index;
                }
            }
            return 0;
        }
    }
}
