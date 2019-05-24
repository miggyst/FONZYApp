using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FONZY
{
	public partial class PrinterDetails : Form
	{
		public PrinterDetails()
		{
			InitializeComponent();
		}

        /// <summary>
        /// allows the user to exit the form and go back to SaleDetails
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// allows the user to open up the desired word document to take a closer look
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OpenButton_Click(object sender, EventArgs e)
        {
            // need to fix file name to not be a hard coded string
            string filename = "C:\\Users\\hedce\\Desktop\\POSTestRunner\\masterFile.xlsx";
            System.Diagnostics.Process.Start(filename);
        }

        /// <summary>
        /// allows the user to do a quick print without opening the desired word document
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PrintButton_Click(object sender, EventArgs e)
        {
            PrintDialog printDialog = new PrintDialog();
            PrintDocument printDocument = new PrintDocument();

            // Need to find a way to create then print the created document
            printDocument.DocumentName = "Print Document";

            printDialog.Document = printDocument;

            printDialog.AllowSelection = true;
            printDialog.AllowSomePages = true;

            if(printDialog.ShowDialog() == DialogResult.OK)
            {
                printDocument.Print();
            }
        }
    }
}
