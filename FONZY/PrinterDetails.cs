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

        /// <summary>
        /// Generates the user's Word document receipt
        /// </summary>
        private void createWordDocument()
        {
            try
            {
                string filePath = (GlobalUtilities.getMasterFilePath()).Remove((GlobalUtilities.getMasterFilePath()).LastIndexOf('\\') + 1);
                string[] dateTimeArray = (DateTime.UtcNow.Date.ToString("dd/MM/yyyy")).Split('/');
                GlobalUtilities.setCustomerOrderFilePath(filePath + GlobalUtilities.getCustomerName() + "_" + dateTimeArray[0] + "-" + dateTimeArray[1] + ".docx");

                Word.Application wordApp = new Microsoft.Office.Interop.Word.Application();
                wordApp.ShowAnimation = false;
                wordApp.Visible = false;
                object missing = System.Reflection.Missing.Value;

                Word.Document wordDocument = wordApp.Documents.Add(ref missing, ref missing, ref missing, ref missing);
                Word.Range rng = wordDocument.Paragraphs[1].Range;
                Word.Paragraph para = wordDocument.Paragraphs.Add(ref missing);

                // Sets the font format for the document to be monospace (easier to edit characters/words to print)
                wordDocument.Content.SetRange(0, 0);
                object styleName = "No Spacing";
                rng.set_Style(ref styleName);
                rng.Font.Size = 11;
                rng.Font.Name = "Consolas";
                rng.Select();

                // There are a total of 77 possible characters per line
                para.Range.Text = Environment.NewLine;
                para.Range.Text = Environment.NewLine;
                para.Range.Text = Environment.NewLine;
                para.Range.Text = Environment.NewLine;
                para.Range.Text = Environment.NewLine;

                // Cashier, Time and Customer Number info
                para.Range.Text = "Cashier: " + GlobalUtilities.getCashierName();
                para.Range.InsertParagraphAfter();
                para.Range.Text = "Time: " + GlobalUtilities.getCashierName();
                para.Range.InsertParagraphAfter();
                para.Range.Text = "Cust. Tel.: " + GlobalUtilities.getCashierName();
                para.Range.InsertParagraphAfter();

                // Some indentation to align text
                para.Range.Text = Environment.NewLine;

                // Customer details: Customer Name, address, TIN, Business Style, Data, Terms, OSCA/PWD ID No., Cardholder's Signature
                para.Range.Text = buildCharacterParagraphArray(10, GlobalUtilities.getCustomerName(), 38, 7, DateTime.UtcNow.Date.ToString("dd/MM/yyyy"));
                para.Range.InsertParagraphAfter();
                para.Range.Text = buildCharacterParagraphArray(10, GlobalUtilities.getCustomerAddress(), 38, 8, GlobalUtilities.getCustomerTerms());
                para.Range.InsertParagraphAfter();
                para.Range.Text = buildCharacterParagraphArray(7, GlobalUtilities.getCustomerTIN(), 41, 18, GlobalUtilities.getCustomerOSCA());
                para.Range.InsertParagraphAfter();
                para.Range.Text = buildCharacterParagraphArray(15, GlobalUtilities.getCustomerBusinessStyle(), 33, 20, "");
                para.Range.InsertParagraphAfter();

                // Customer order details breakdown
                para.Range.Text = Environment.NewLine;
                para.Range.Text = "INSERT CUSTOMER ORDER DETAILS HERE!";
                para.Range.InsertParagraphAfter();


                //Save the document  
                object documentFilePath = GlobalUtilities.getCustomerOrderFilePath();//@"C:\Users\hedce\Desktop\POSTestRunner\testFile.docx";
                wordDocument.SaveAs2(ref documentFilePath);
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
        /// Builds a one line string entry that takes in up to two string values
        /// </summary>
        /// <param name="initialSpaceCount"></param>
        /// <param name="initialStringValue"></param>
        /// <param name="secondarySpaceCount"></param>
        /// <param name="secondaryStringValue"></param>
        /// <returns></returns>
        private string buildCharacterParagraphArray(int initialSpaceCount, string initialStringValue, int stringSpaceAllowanceCount, int secondarySpaceCount, string secondaryStringValue)
        {
            List<string> paraList = new List<string>();
            char[] initialStringValueCharArray = initialStringValue.ToCharArray();
            char[] secondaryStringValueCharArray = secondaryStringValue.ToCharArray();
            int j = 0;
            int k = 0;

            for(int i = 0; i < 77; i++)
            {
                if (i < initialSpaceCount)
                {
                    paraList.Add(" ");
                }
                else
                {
                    if (i < (stringSpaceAllowanceCount + initialSpaceCount))
                    {
                        if (j < initialStringValue.Length)
                        {
                            paraList.Add(initialStringValueCharArray[j].ToString());
                            j++;
                        }
                        else
                        {
                            paraList.Add(" ");
                        }
                    }
                    else
                    {
                        if (i < (stringSpaceAllowanceCount + initialSpaceCount + secondarySpaceCount))
                        {
                            paraList.Add(" ");
                        }
                        else
                        {
                            if (k < (secondaryStringValue.Length))
                            {
                                paraList.Add(secondaryStringValueCharArray[k].ToString());
                                k++;
                            }
                            else
                            {
                                paraList.Add(" ");
                            }
                        }
                    }
                }
            }
            return string.Join("", paraList);
        }
    }
}
