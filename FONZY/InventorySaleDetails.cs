using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace FONZY
{
    public partial class InventorySaleDetails : Form
    {
        List<string> keyList = new List<string>(GlobalUtilities.getMasterListDictionary().Keys);
        private Microsoft.Office.Interop.Excel.Application xlApp = new Excel.Application();
        private Excel.Workbook xlWorkbook;
        private Excel.Worksheet xlWorksheet;
        DateTime lastKeyPress = DateTime.Now;

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
            if (String.IsNullOrWhiteSpace(productBarCodeTextBox.Text) || !GlobalUtilities.isInDictionary(GlobalUtilities.MASTER, (productBarCodeTextBox.Text).TrimStart(new Char[] { '0' })))
            {
                productBarCodeTextBox.Focus();
                //quantityNumericUpDown.Value = 1;
                //productBarCodeTextBox.Text = "";
                return;
            }

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

            GlobalUtilities.addToDictionary(GlobalUtilities.MASTER, productBarCodeTextBox.Text, customerProductOrder);

            totalQuantityTextBox.Text = GlobalUtilities.getTotalQuantity();
            productBarCodeTextBox.Focus();
            productBarCodeTextBox.Text = String.Empty;
            quantityNumericUpDown.Value = 1;
        }

        /// <summary>
        /// Updates Excel sheet and closes the application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ProcessButton_Click(object sender, EventArgs e)
        {
            addProductButton.PerformClick();
            try
            {
                // Opens Excel Sheet
                xlApp = new Excel.Application();
                xlApp.Visible = false;
                xlApp.DisplayAlerts = false;
                xlWorkbook = xlApp.Workbooks.Open(GlobalUtilities.getMasterFilePath(), 0, false, 5, "", "", false, Microsoft.Office.Interop.Excel.XlPlatform.xlWindows, "", true, false, 0, true, false, false);
                xlWorksheet = (Excel.Worksheet)xlWorkbook.Worksheets.get_Item(1);

                // Edits Excel Sheet
                Excel.Range xlRange = xlWorksheet.UsedRange;

                for (int i = 1; i <= xlRange.Rows.Count + 10; i++)
                {
                    if (((Microsoft.Office.Interop.Excel.Range)xlWorksheet.Cells[i, 5]).Value != null)
                    {
                        object cellValue = ((Microsoft.Office.Interop.Excel.Range)xlWorksheet.Cells[i, 5]).Value;
                        string cellValueString = cellValue.ToString();
                        if (GlobalUtilities.getMasterListDictionary().ContainsKey(cellValueString.TrimStart(new Char[] { '0' })) && !Regex.IsMatch(cellValueString.Replace(" ", ""), @"^[a-zA-Z]+$"))
                        {
                            List<string> tempMasterListDictionaryProduct = new List<string>(GlobalUtilities.getMasterListDictionary()[cellValueString.TrimStart(new Char[] { '0' })]);
                            object quantityCellValue = ((Microsoft.Office.Interop.Excel.Range)xlWorksheet.Cells[i, 6]).Value;
                            string quantityCellValueString;
                            if (quantityCellValue != null)
                            {
                                quantityCellValueString = quantityCellValue.ToString();
                            }
                            else
                            {
                                quantityCellValueString = "0";
                            }
                            if (!string.IsNullOrWhiteSpace(quantityCellValueString))
                            {
                                xlWorksheet.Cells[i, 6] = Double.Parse(quantityCellValueString) + Double.Parse(tempMasterListDictionaryProduct[4].ToString());
                            }
                            else
                            {
                                xlWorksheet.Cells[i, 6] = Double.Parse(tempMasterListDictionaryProduct[4].ToString());
                            }
                        }
                    }
                }

                // Saves Excel sheet
                xlWorkbook.SaveAs(GlobalUtilities.getMasterFilePath());
                xlWorkbook.Close(true, Type.Missing, Type.Missing);
                xlApp.Quit();
                if (xlWorkbook != null) { Marshal.ReleaseComObject(xlWorkbook); } //release each workbook like this
                if (xlWorksheet != null) { Marshal.ReleaseComObject(xlWorksheet); } //release each worksheet like this
                if (xlApp != null) { Marshal.ReleaseComObject(xlApp); } //release the Excel application
                xlWorkbook = null; //set each memory reference to null.
                xlWorksheet = null;
                xlApp = null;
                GC.Collect();
            }
            catch (Exception ex)
            {
                // Saves Excel sheet
                xlApp.Quit();
                //release all memory - stop EXCEL.exe from hanging around.
                if (xlWorkbook != null) { Marshal.ReleaseComObject(xlWorkbook); } //release each workbook like this
                if (xlWorksheet != null) { Marshal.ReleaseComObject(xlWorksheet); } //release each worksheet like this
                if (xlApp != null) { Marshal.ReleaseComObject(xlApp); } //release the Excel application
                xlWorkbook = null; //set each memory reference to null.
                xlWorksheet = null;
                xlApp = null;
                GC.Collect();
                MessageBox.Show(ex.Message);
            }

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

        /// <summary>
        /// Allows the user to press the 'Enter' key to prompt the Add button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ProductBarCodeTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                addProductButton.PerformClick();
            }
            if (((TimeSpan)(DateTime.Now - lastKeyPress)).TotalMilliseconds > 20)
            {
                addProductButton.PerformClick();
            }
            lastKeyPress = DateTime.Now;
        }

        /// <summary>
        /// Allows the user to press the 'Enter' key to prompt the Add button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void QuantityNumericUpDown_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                addProductButton.PerformClick();
            }
        }
    }
}
