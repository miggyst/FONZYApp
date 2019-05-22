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

        }

        /// <summary>
        /// saves the data input on SaleDetails form into GlobalUtilities,
        /// then redirected to CodeDetails form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ProcessButton_Click(object sender, EventArgs e)
        {
            //NEED TO DISABLE PROCESS BUTTON WHEN THERE ISN'T ANY DATA INSIDE DataGridView
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
            if (GlobalUtilities.isInCustomerTransactionDictionary(productBarCodeTextBox.Text))
            {
                DataGridViewRow updateDataGridViewRow = productOrderDataGridView.Rows[rowSearchWithMatchingBarCodes(productBarCodeTextBox.Text)];
                updateDataGridViewRow.Cells[3].Value = (Double.Parse(updateDataGridViewRow.Cells[3].Value.ToString()) + (double)quantityNumericUpDown.Value).ToString();
                updateDataGridViewRow.Cells[5].Value = GlobalUtilities.calculatePrice(updateDataGridViewRow.Cells[2].Value.ToString(), updateDataGridViewRow.Cells[3].Value.ToString(), updateDataGridViewRow.Cells[4].Value.ToString());

                Console.WriteLine(updateDataGridViewRow.Cells[5].Value);

                customerProductOrder.Add(updateDataGridViewRow.Cells[1].Value.ToString());
                customerProductOrder.Add(updateDataGridViewRow.Cells[2].Value.ToString());
                customerProductOrder.Add(updateDataGridViewRow.Cells[3].Value.ToString());
                customerProductOrder.Add(updateDataGridViewRow.Cells[4].Value.ToString());
                customerProductOrder.Add(updateDataGridViewRow.Cells[5].Value.ToString());
                GlobalUtilities.addToDictionary(GlobalUtilities.CUSTOMER, productBarCodeTextBox.Text, customerProductOrder);
            }
            else
            {
                customerProductOrder = GlobalUtilities.getProductInfoFromDictionary(GlobalUtilities.MASTER, productBarCodeTextBox.Text);
                customerProductOrder[3] = (Double.Parse(customerProductOrder[3]) + (double)quantityNumericUpDown.Value).ToString();

                //                                    Bar Code              Product Description             Price                 Quantity                  Discount                  Amount 
                productOrderDataGridView.Rows.Add(customerProductOrder[0], customerProductOrder[1], customerProductOrder[2], customerProductOrder[3], customerProductOrder[4], customerProductOrder[5]);

                customerProductOrder.RemoveAt(0);
                GlobalUtilities.addToDictionary(GlobalUtilities.CUSTOMER, productBarCodeTextBox.Text, customerProductOrder);
            }

            // NEED TO UPDATE TOTAL QUANTITY AND TOTAL AMOUNT HERE!
            updateSaleDetailsForm();
            addProductButton.Focus();
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
        /// Updates the GlobalUtilities Name, Phone, Address, Total Price, Total Quantity
        /// and also updates the UI to showcase the saved data/changes in the DataGridView
        /// </summary>
        private void updateSaleDetailsForm()
        {

        }
    }
}
