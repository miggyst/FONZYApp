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
using Word = Microsoft.Office.Interop.Word;

namespace FONZY
{
	public partial class PrinterDetails : Form
	{
		public PrinterDetails()
		{
			InitializeComponent();
		}

        /// <summary>
        /// Generate the product order Word document on form load.
        /// Also add the user order information to the cashier's Excel sheet
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PrinterDetails_Load(object sender, EventArgs e)
        {
            createWordDocument();
            updateCashierExcelSheet();
        }

        /// <summary>
        /// Generates the user's Word document receipt
        /// </summary>
        private void createWordDocument()
        {
            try
            {

            
                Word.Application wordApp = new Microsoft.Office.Interop.Word.Application();
                wordApp.ShowAnimation = false;
                wordApp.Visible = false;
                object missing = System.Reflection.Missing.Value;

                Word.Document wordDocument = wordApp.Documents.Add(ref missing, ref missing, ref missing, ref missing);

                // Set the Range to the first paragraph. 
                Word.Range rng = wordDocument.Paragraphs[1].Range;

                // Change the formatting. To change the font size for a right-to-left language,
                rng.Font.Size = 14;
                rng.Font.Name = "Consolas";

                rng.Select();

                //adding text to document
                wordDocument.Content.SetRange(0, 0);
                wordDocument.Content.Text = "This is test document " + Environment.NewLine;


                //Save the document  
                object filename = @"c:\temp1.docx";
                wordDocument.SaveAs2(ref filename);
                wordDocument.Close(ref missing, ref missing, ref missing);
                wordDocument = null;
                wordApp.Quit(ref missing, ref missing, ref missing);
                wordApp = null;
            }  
            catch (Exception ex)
            {  
                MessageBox.Show(ex.Message);  
            }


        }

        /// <summary>
        /// Updates the cashier's Excel sheet to include customer order
        /// </summary>
        private void updateCashierExcelSheet()
        {

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
            System.Diagnostics.Process.Start(GlobalUtilities.getCashierAndEventFilePath());
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
