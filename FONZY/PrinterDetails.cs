using Microsoft.Office.Interop.Word;
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
using Excel = Microsoft.Office.Interop.Excel;
using System.Runtime.InteropServices;

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
        /// allows the user to open up the desired word document to take a closer look
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OpenButton_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(GlobalUtilities.getCustomerOrderFilePath());
        }

        /// <summary>
        /// allows the user to do a quick print without opening the desired word document
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PrintButton_Click(object sender, EventArgs e)
        {
            Word.Application wordApp = new Word.Application { Visible = false };
            Word.Document wordDocument = wordApp.Documents.Open(GlobalUtilities.getCustomerOrderFilePath(), ReadOnly: false, Visible: false);
            wordDocument.Activate();
            wordDocument.PrintOut();
        }

        /// <summary>
        /// Generates the user's Word document receipt
        /// </summary>
        private void createWordDocument()
        {
            try
            {
                string filePath = (GlobalUtilities.getMasterFilePath()).Remove((GlobalUtilities.getMasterFilePath()).LastIndexOf('\\') + 1);
                string[] dateTimeArray = (DateTime.Now.Date.ToString("dd/MM/yyyy")).Split('/');
                GlobalUtilities.setCustomerOrderFilePath(filePath + GlobalUtilities.getCustomerName() + "_" + dateTimeArray[0] + "-" + dateTimeArray[1] + "-" + dateTimeArray[2] + ".docx");

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
                para.Range.Text = "Cashier: " + GlobalUtilities.getCashierName() + Environment.NewLine;
                para.Range.Text = "Time: " + GlobalUtilities.getCashierName() + Environment.NewLine;
                para.Range.Text = "Cust. Tel.: " + GlobalUtilities.getCashierName() + Environment.NewLine;

                // Some indentation to align text
                para.Range.Text = Environment.NewLine;

                // Customer details: Customer Name, address, TIN, Business Style, Data, Terms, OSCA/PWD ID No., Cardholder's Signature
                para.Range.Text = buildCharacterParagraphArray(10, GlobalUtilities.getCustomerName(), 38, 7, DateTime.Now.Date.ToString("dd/MM/yyyy")) + Environment.NewLine;
                para.Range.Text = buildCharacterParagraphArray(10, GlobalUtilities.getCustomerAddress(), 38, 8, GlobalUtilities.getCustomerTerms()) + Environment.NewLine;
                para.Range.Text = buildCharacterParagraphArray(7, GlobalUtilities.getCustomerTIN(), 41, 18, GlobalUtilities.getCustomerOSCA()) + Environment.NewLine;
                para.Range.Text = buildCharacterParagraphArray(15, GlobalUtilities.getCustomerBusinessStyle(), 33, 20, "") + Environment.NewLine;

                // Customer order details title
                para.Range.Text = Environment.NewLine;
                para.Range.Text = "Item Number        Description                        Qty   Price   Amount" + Environment.NewLine;
                para.Range.Text = Environment.NewLine;

                // Customer order details breakdown
                List<string> keyList = new List<string>(GlobalUtilities.getCustomerTransactionDictionary().Keys);
                for (int i = 0; i < GlobalUtilities.getCustomerTransactionDictionary().Count; i++)
                {
                    para.Range.Text = buildBodyParagraphArray(keyList[i]) + Environment.NewLine;
                }
                for (int j = 0; j < (20 - GlobalUtilities.getCustomerTransactionDictionary().Count); j++)
                {
                    para.Range.Text = Environment.NewLine;
                }
                para.Range.Text = Environment.NewLine;
                para.Range.Text = buildTotalParagraphArray() + Environment.NewLine;

                // Sales data
                double vatSales = GlobalUtilities.getTotalCost() * 0.88;
                double vat = GlobalUtilities.getTotalCost() * 0.12;
                para.Range.Text = Environment.NewLine;
                para.Range.Text = Environment.NewLine;
                para.Range.Text = buildCharacterParagraphArray(68, "", 0, 0, vatSales.ToString()) + Environment.NewLine;
                para.Range.Text = Environment.NewLine;
                para.Range.Text = Environment.NewLine;
                para.Range.Text = buildCharacterParagraphArray(68, "", 0, 0, GlobalUtilities.getTotalCost().ToString()) + Environment.NewLine;
                para.Range.Text = buildCharacterParagraphArray(68, "", 0, 0, vat.ToString()) + Environment.NewLine;
                para.Range.Text = buildCharacterParagraphArray(68, "", 0, 0, GlobalUtilities.getTotalCost().ToString()) + Environment.NewLine;
                para.Range.Text = Environment.NewLine;
                para.Range.Text = buildCharacterParagraphArray(62, "", 0, 0, GlobalUtilities.getTotalCustomerPayment().ToString()) + Environment.NewLine;
                para.Range.Text = buildCharacterParagraphArray(62, "", 0, 0, GlobalUtilities.getTotalChange()) + Environment.NewLine;   // Change String.Format("{0:n}", GlobalUtilities.getTotalChange())

                //Save the document  
                object documentFilePath = GlobalUtilities.getCustomerOrderFilePath();
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
        /// Updates the cashier's Excel sheet to include customer order
        /// </summary>
        private void updateCashierExcelSheet()
        {
            // Opens Excel Sheet
            Excel.Application xlApp = new Excel.Application();
            xlApp.Visible = false;
            xlApp.DisplayAlerts = false;
            Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(GlobalUtilities.getCashierAndEventFilePath(), 0, false, 5, "", "", false, Microsoft.Office.Interop.Excel.XlPlatform.xlWindows, "", true, false, 0, true, false, false);
            Excel.Worksheet xlWorksheet = (Excel.Worksheet)xlWorkbook.Worksheets.get_Item(1);

            // Edits Excel Sheet
            Excel.Range xlRange = xlWorksheet.UsedRange;
            int rowCount = xlRange.Rows.Count + 1;
            string date = DateTime.Now.Date.ToString("dd/MM/yyyy");
            string time = DateTime.Now.ToString("h:mm:ss tt");
            List<string> keyList = new List<string>(GlobalUtilities.getCustomerTransactionDictionary().Keys);
            double percentCash = Double.Parse(GlobalUtilities.getCashPayment()) / GlobalUtilities.getTotalCustomerPayment();
            double percentDebit = Double.Parse(GlobalUtilities.getDebitPayment()) / GlobalUtilities.getTotalCustomerPayment();
            double percentCredit = Double.Parse(GlobalUtilities.getCreditPayment()) / GlobalUtilities.getTotalCustomerPayment();
            double percentCheck = Double.Parse(GlobalUtilities.getCheckPayment()) / GlobalUtilities.getTotalCustomerPayment();
            double percentSalaryDeduction = Double.Parse(GlobalUtilities.getSalaryDeductionPayment()) / GlobalUtilities.getTotalCustomerPayment();

            for (int i = 0; i < GlobalUtilities.getCustomerTransactionDictionary().Count; i++)
            {
                List<string> customerOrder = GlobalUtilities.getProductInfoFromDictionary(GlobalUtilities.CUSTOMER, keyList[i]);

                xlWorksheet.Cells[rowCount + i, 1] = GlobalUtilities.getCustomerName();
                xlWorksheet.Cells[rowCount + i, 2] = keyList[i];
                xlWorksheet.Cells[rowCount + i, 3] = customerOrder[1];
                xlWorksheet.Cells[rowCount + i, 4] = customerOrder[2];
                xlWorksheet.Cells[rowCount + i, 5] = customerOrder[3];
                xlWorksheet.Cells[rowCount + i, 6] = customerOrder[4];
                xlWorksheet.Cells[rowCount + i, 7] = Double.Parse(customerOrder[4]) * percentCash;
                xlWorksheet.Cells[rowCount + i, 8] = Double.Parse(customerOrder[4]) * percentDebit;
                xlWorksheet.Cells[rowCount + i, 9] = Double.Parse(customerOrder[4]) * percentDebit;
                xlWorksheet.Cells[rowCount + i, 10] = Double.Parse(customerOrder[4]) * percentCredit;
                xlWorksheet.Cells[rowCount + i, 11] = Double.Parse(customerOrder[4]) * percentCheck;
                xlWorksheet.Cells[rowCount + i, 12] = Double.Parse(customerOrder[4]) * percentSalaryDeduction;
                xlWorksheet.Cells[rowCount + i, 13] = date;
                xlWorksheet.Cells[rowCount + i, 14] = time;
            }

            // Saves Excel sheet
            xlWorkbook.SaveAs(GlobalUtilities.getCashierAndEventFilePath());
            xlWorkbook.Close(true, Type.Missing, Type.Missing);
            xlApp.Quit();

            Marshal.ReleaseComObject(xlWorksheet);
            Marshal.ReleaseComObject(xlWorkbook);
            Marshal.ReleaseComObject(xlApp);
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

        /// <summary>
        /// Builds the body that can host up to 20 customer orders.
        /// Displays Item number, Description, Quantity, Price, and Amount
        /// </summary>
        /// <param name="customerKey"></param>
        /// <returns></returns>
        private string buildBodyParagraphArray(string customerKey)
        {
            List<string> paraList = new List<string>();
            List<string> customerOrder = GlobalUtilities.getProductInfoFromDictionary(GlobalUtilities.CUSTOMER, customerKey);

            char[] barCodeCharArray = customerKey.ToCharArray();
            char[] productDescriptionCharArray = customerOrder[1].ToCharArray();
            char[] priceCharArray = customerOrder[2].ToCharArray();
            char[] quantityCharArray = customerOrder[3].ToCharArray();
            char[] amountCharArray = customerOrder[4].ToCharArray();

            // Item Number
            for (int i = 0; i < 16; i++)
            {
                if (i < customerKey.Length)
                {
                    paraList.Add(barCodeCharArray[i].ToString());
                }
                else
                {
                    paraList.Add(" ");
                }
            }
            for (int numSpace = 0; numSpace < 3; numSpace++)
            {
                paraList.Add(" ");
            }

            // Description
            for (int j = 0; j < 32; j ++)
            {
                if (j < customerOrder[1].Length)
                {
                    paraList.Add(productDescriptionCharArray[j].ToString());
                }
                else
                {
                    paraList.Add(" ");
                }
            }
            for (int numSpace = 0; numSpace < 3; numSpace++)
            {
                paraList.Add(" ");
            }

            // Quantity
            for (int k = 0; k < 3; k++)
            {
                if (k < customerOrder[3].Length)
                {
                    paraList.Add(quantityCharArray[k].ToString());
                }
                else
                {
                    paraList.Add(" ");
                }
            }
            for (int numSpace = 0; numSpace < 3; numSpace++)
            {
                paraList.Add(" ");
            }

            // Price
            for (int l = 0; l < 5; l++)
            {
                if (l < customerOrder[2].Length)
                {
                    paraList.Add(priceCharArray[l].ToString());
                }
                else
                {
                    paraList.Add(" ");
                }
            }
            for (int numSpace = 0; numSpace < 3; numSpace++)
            {
                paraList.Add(" ");
            }

            // Amount
            for (int m = 0; m < 9; m++)
            {
                if (m < customerOrder[4].Length)
                {
                    paraList.Add(amountCharArray[m].ToString());
                }
                else
                {
                    paraList.Add(" ");
                }
            }

            return string.Join("", paraList);
        }

        /// <summary>
        /// Builds the total paragraph to display total quantity and amount
        /// </summary>
        /// <returns></returns>
        private string buildTotalParagraphArray()
        {
            List<string> paraList = new List<string>();
            paraList.Add("                                              Total  ");
            char[] totalQuantity = GlobalUtilities.getTotalQuantity().ToCharArray();
            char[] totalCost = GlobalUtilities.getTotalCost().ToString().ToCharArray();

            for (int i = 0; i < 15; i++)
            {
                if (i < GlobalUtilities.getTotalQuantity().Length)
                {
                    paraList.Add(totalQuantity[i].ToString());
                }
                else
                {
                    paraList.Add(" ");
                }
            }

            for (int j = 0; j < 9; j++)
            {
                if (j < GlobalUtilities.getTotalCost().ToString().Length)
                {
                    paraList.Add(totalCost[j].ToString());
                }
                else
                {
                    paraList.Add(" ");
                }
            }
            return string.Join("", paraList);
        }

        /// <summary>
        /// allows the user to exit the form and go back to SaleDetails
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ProceedButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
