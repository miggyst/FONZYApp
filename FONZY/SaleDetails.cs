using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FONZY
{
	public partial class SaleDetails : Form
	{
		public SaleDetails()
		{
			InitializeComponent();
		}

        /// <summary>
        /// On form load, disable SaleDetails form and load ChooseApplication
        /// to proceed with the workflow.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaleDetails_Load(object sender, EventArgs e)
        {
            ChooseApplication chooseApplication = new ChooseApplication();
            chooseApplication.ShowDialog();
            nameTextBox.Focus();
            processButton.Enabled = false;

        }

        /// <summary>
        /// saves the data input on SaleDetails form into GlobalUtilities,
        /// then redirected to CodeDetails form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ProcessButton_Click(object sender, EventArgs e)
        {
            GlobalUtilities.setCustomerName(nameTextBox.Text);
            GlobalUtilities.setCustomerAddress(addressTextBox.Text);
            GlobalUtilities.setCustomerContact(phoneTextBox.Text);
            CodeDetails codeDetails = new CodeDetails();
            codeDetails.ShowDialog();
        }

        /// <summary>
        /// button searches takes the userInput text from the text box and searches the dictionary for the product.
        /// If the product exists, add it to the DataGridView,
        /// else neglect the input.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddProductButton_Click(object sender, EventArgs e)
        {
            List<string> customerProductOrder = new List<string>();

            // Check customerTransactionDictionary. if available find the list and update, else search masterListDictionary and add it into customerTransactionDictionary
            // then update the DataGridView as necessary
            if (GlobalUtilities.isInDictionary(GlobalUtilities.CUSTOMER, productBarCodeTextBox.Text))
            {
                DataGridViewRow updateDataGridViewRow = productOrderDataGridView.Rows[rowSearchWithMatchingBarCodes(productBarCodeTextBox.Text)];
                int totalQuantityCheck = Int32.Parse(updateDataGridViewRow.Cells[3].Value.ToString()) + (int)quantityNumericUpDown.Value;

                if (totalQuantityCheck <= 0)
                {
                    productOrderDataGridView.Rows.RemoveAt(rowSearchWithMatchingBarCodes(productBarCodeTextBox.Text));

                    GlobalUtilities.setTotalQuantity((Int32.Parse(GlobalUtilities.getTotalQuantity()) - Int32.Parse(updateDataGridViewRow.Cells[3].Value.ToString())).ToString());
                    GlobalUtilities.setTotalCost(GlobalUtilities.getTotalCost() - Double.Parse(GlobalUtilities.calculatePrice(updateDataGridViewRow.Cells[2].Value.ToString(), updateDataGridViewRow.Cells[3].Value.ToString(), updateDataGridViewRow.Cells[4].Value.ToString())));

                    (GlobalUtilities.getCustomerTransactionDictionary()).Remove(productBarCodeTextBox.Text);

                    totalQuantityTextBox.Text = GlobalUtilities.getTotalQuantity();
                    totalCostTextBox.Text = (GlobalUtilities.getTotalCost()).ToString();
                    productBarCodeTextBox.Focus();

                    productBarCodeTextBox.Text = "";

                    return ;
                }

                GlobalUtilities.setTotalQuantity((Int32.Parse(GlobalUtilities.getTotalQuantity()) + Int32.Parse(quantityNumericUpDown.Value.ToString())).ToString());
                GlobalUtilities.setTotalCost(GlobalUtilities.getTotalCost() + Double.Parse(GlobalUtilities.calculatePrice(updateDataGridViewRow.Cells[2].Value.ToString(), quantityNumericUpDown.Value.ToString(), updateDataGridViewRow.Cells[4].Value.ToString())));

                updateDataGridViewRow.Cells[3].Value = totalQuantityCheck;
                updateDataGridViewRow.Cells[5].Value = GlobalUtilities.calculatePrice(updateDataGridViewRow.Cells[2].Value.ToString(), updateDataGridViewRow.Cells[3].Value.ToString(), updateDataGridViewRow.Cells[4].Value.ToString());

                customerProductOrder.Add(updateDataGridViewRow.Cells[1].Value.ToString());
                customerProductOrder.Add(updateDataGridViewRow.Cells[2].Value.ToString());
                customerProductOrder.Add(updateDataGridViewRow.Cells[3].Value.ToString());
                customerProductOrder.Add(updateDataGridViewRow.Cells[4].Value.ToString());
                customerProductOrder.Add(updateDataGridViewRow.Cells[5].Value.ToString());
                GlobalUtilities.addToDictionary(GlobalUtilities.CUSTOMER, productBarCodeTextBox.Text, customerProductOrder);
            }
            else
            {
                if ((int)quantityNumericUpDown.Value <= 0 || String.IsNullOrWhiteSpace(productBarCodeTextBox.Text) || !GlobalUtilities.isInDictionary(GlobalUtilities.MASTER, (productBarCodeTextBox.Text).TrimStart(new Char[] { '0' })))
                {
                    return;
                }
                customerProductOrder = GlobalUtilities.getProductInfoFromDictionary(GlobalUtilities.MASTER, (productBarCodeTextBox.Text).TrimStart(new Char[] { '0' }));
                customerProductOrder[3] = (Int32.Parse(customerProductOrder[3]) + (int)quantityNumericUpDown.Value).ToString();
                customerProductOrder[5] = GlobalUtilities.calculatePrice(customerProductOrder[2], customerProductOrder[3], customerProductOrder[4]);

                //                                        Bar Code              Product Description             Price                 Quantity                  Discount                  Amount 
                productOrderDataGridView.Rows.Add(productBarCodeTextBox.Text, customerProductOrder[1], customerProductOrder[2], customerProductOrder[3], customerProductOrder[4], customerProductOrder[5]);

                customerProductOrder.RemoveAt(0);
                GlobalUtilities.addToDictionary(GlobalUtilities.CUSTOMER, productBarCodeTextBox.Text, customerProductOrder);

                GlobalUtilities.setTotalQuantity((Int32.Parse(GlobalUtilities.getTotalQuantity()) + Int32.Parse(customerProductOrder[2])).ToString());
                GlobalUtilities.setTotalCost(GlobalUtilities.getTotalCost() + Double.Parse(GlobalUtilities.calculatePrice(customerProductOrder[1], customerProductOrder[2], customerProductOrder[3])));
            }

            totalQuantityTextBox.Text = GlobalUtilities.getTotalQuantity();
            totalCostTextBox.Text = (GlobalUtilities.getTotalCost()).ToString();

            productBarCodeTextBox.Text = "";
            quantityNumericUpDown.Value = 1;

            if (canProcessOrder())
            {
                processButton.Enabled = true;
            }
            else
            {
                processButton.Enabled = false;
            }

            productBarCodeTextBox.Focus();
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

        /// <summary>
        /// Checks if nameTextBox, phoneTextBox, addressTextBox, and productOrderDataGridView has input,
        /// if so, enabled the processButton, else disable processButton
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (canProcessOrder())
            {
                processButton.Enabled = true;
            }
            else
            {
                processButton.Enabled = false;
            }
        }

        /// <summary>
        /// Checks if nameTextBox, phoneTextBox, addressTextBox, and productOrderDataGridView has input,
        /// if so, enabled the processButton, else disable processButton
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PhoneTextBox_TextChanged(object sender, EventArgs e)
        {
            if (canProcessOrder())
            {
                processButton.Enabled = true;
            }
            else
            {
                processButton.Enabled = false;
            }
        }

        /// <summary>
        /// Checks if nameTextBox, phoneTextBox, addressTextBox, and productOrderDataGridView has input,
        /// if so, enabled the processButton, else disable processButton
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddressTextBox_TextChanged(object sender, EventArgs e)
        {
            if (canProcessOrder())
            {
                processButton.Enabled = true;
            }
            else
            {
                processButton.Enabled = false;
            }
        }

        /// <summary>
        /// Checks if nameTextBox, phoneTextBox, addressTextBox, and productOrderDataGridView has input,
        /// if so, return true, else returns false
        /// </summary>
        /// <returns></returns>
        private bool canProcessOrder()
        {
            if (!String.IsNullOrWhiteSpace(nameTextBox.Text) && !String.IsNullOrWhiteSpace(phoneTextBox.Text) && !String.IsNullOrWhiteSpace(addressTextBox.Text) && (productOrderDataGridView.Rows.Count > 1))
            {
                return true;
            }
            return false;
        }
    }
}
