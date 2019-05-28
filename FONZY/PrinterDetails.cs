﻿using System;
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
            System.Diagnostics.Process.Start(GlobalUtilities.getCustomerOrderFilePath());
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
                para.Range.Text = "Cashier: " + GlobalUtilities.getCashierName() + Environment.NewLine;
                para.Range.Text = "Time: " + GlobalUtilities.getCashierName() + Environment.NewLine;
                para.Range.Text = "Cust. Tel.: " + GlobalUtilities.getCashierName() + Environment.NewLine;

                // Some indentation to align text
                para.Range.Text = Environment.NewLine;

                // Customer details: Customer Name, address, TIN, Business Style, Data, Terms, OSCA/PWD ID No., Cardholder's Signature
                para.Range.Text = buildCharacterParagraphArray(10, GlobalUtilities.getCustomerName(), 38, 7, DateTime.UtcNow.Date.ToString("dd/MM/yyyy")) + Environment.NewLine;
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
                para.Range.Text = Environment.NewLine;
                para.Range.Text = Environment.NewLine;
                para.Range.Text = "VATable Sales" + Environment.NewLine;
                para.Range.Text = Environment.NewLine;
                para.Range.Text = Environment.NewLine;
                para.Range.Text = "Total Sales" + Environment.NewLine;
                para.Range.Text = "Add. Vat" + Environment.NewLine;
                para.Range.Text = "Total Amt" + Environment.NewLine;
                para.Range.Text = Environment.NewLine;
                para.Range.Text = "Amount Paid" + Environment.NewLine;
                para.Range.Text = "Change" + Environment.NewLine;

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
    }
}
