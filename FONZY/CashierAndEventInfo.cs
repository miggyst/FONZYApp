using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace FONZY
{
	public partial class CashierAndEventInfo : Form
	{
		public CashierAndEventInfo()
		{
			InitializeComponent();
		}

        /// <summary>
        /// disables the button on form load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CashierAndEventInfo_Load(object sender, EventArgs e)
        {
            cashierAndEventButton.Enabled = false;
        }

        /// <summary>
        /// validates data on cashier name text box
        /// disables button if null, empty or whitespace on text box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cashierNameTextBoxValidating(object sender, CancelEventArgs e)
        {
            if(string.IsNullOrWhiteSpace(cashierNameTextBox.Text))
            {
                cashierAndEventButton.Enabled = false;
            }
            else
            {
                cashierAndEventButton.Enabled = true;
            }
        }

        /// <summary>
        /// validates data on event name text box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void eventNameTextBoxValidating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(eventNameTextBox.Text))
            {
                cashierAndEventButton.Enabled = false;
            }
            else
            {
                cashierAndEventButton.Enabled = true;
            }
        }

        /// <summary>
        /// cashierAndEventButton will store the user input into the global utilities file for future use,
        /// then create an excel file for this cashier or open/update an existing file,
        /// then will be redirected back to SaleDetails form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CashierAndEventButton_Click(object sender, EventArgs e)
        {
            // Creates the filepath for the cashier+event excel file
            string filePath = (GlobalUtilities.getMasterFilePath()).Remove((GlobalUtilities.getMasterFilePath()).LastIndexOf('\\') + 1);
            string[] dateTimeArray = (DateTime.UtcNow.Date.ToString("dd/MM/yyyy")).Split('/');
            GlobalUtilities.setCashierAndEventFilePath(filePath + cashierNameTextBox.Text + "_" + eventNameTextBox.Text + "_" + dateTimeArray[0] + "-" + dateTimeArray[1]);

            // Checks if the file already exists, if so update, if not create a new file
            if (!System.IO.File.Exists(GlobalUtilities.getCashierAndEventFilePath())) // Create a new file
            {
                Excel.Application xlApp = new Excel.Application();
                Excel.Workbook xlWorkbook = xlApp.Workbooks.Add(System.Reflection.Missing.Value);
                Excel.Worksheet xlWorksheet = (Excel.Worksheet)xlWorkbook.Worksheets.get_Item(1);

                xlWorksheet.Cells[1, 1] = "Customer Name";
                xlWorksheet.Cells[1, 2] = "Barcode Number";
                xlWorksheet.Cells[1, 3] = "Product Description";
                xlWorksheet.Cells[1, 4] = "Price";
                xlWorksheet.Cells[1, 5] = "Quantity";
                xlWorksheet.Cells[1, 6] = "Total Amount";
                xlWorksheet.Cells[1, 7] = "Customer Type";
                xlWorksheet.Cells[1, 8] = "Cash";
                xlWorksheet.Cells[1, 9] = "Debit";
                xlWorksheet.Cells[1, 10] = "Credit";
                xlWorksheet.Cells[1, 11] = "Check";
                xlWorksheet.Cells[1, 12] = "Salary Deduction";
                xlWorksheet.Cells[1, 13] = "Date";
                xlWorksheet.Cells[1, 14] = "Time";

                xlWorkbook.SaveAs(GlobalUtilities.getCashierAndEventFilePath());
                xlWorkbook.Close(true);
                xlApp.Quit();

                Marshal.ReleaseComObject(xlWorksheet);
                Marshal.ReleaseComObject(xlWorkbook);
                Marshal.ReleaseComObject(xlApp);
            }
            else // Update the file
            {
                // Maybe set the file row/column in the globalutilities???
            }

            this.Close();
            GlobalUtilities.setCashierName(cashierNameTextBox.Text);
            GlobalUtilities.setEventName(eventNameTextBox.Text);
        }
    }
}
