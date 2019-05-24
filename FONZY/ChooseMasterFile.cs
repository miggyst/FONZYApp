using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Excel = Microsoft.Office.Interop.Excel;

namespace FONZY
{
	public partial class ChooseMasterFile : Form
	{
		public ChooseMasterFile()
		{
			InitializeComponent();
		}

        /// <summary>
        /// masterFile button will open a file explorer for the user to use and search
        /// for the master file to fill the data hash set within the GlobalUtilities file,
        /// then redirects it to CashierAndEventInfo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MasterFileButton_Click(object sender, EventArgs e)
        {
            // Opens file explorer and stores filename, and the contents of the excel file to global utilities
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Excel Worksheets|*.xls; *.xlsx";
            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                GlobalUtilities.setMasterFilePath(openFileDialog.FileName);
            }

            // Stores excel data onto Dictionary
            Excel.Application xlApp = new Excel.Application();
            Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(GlobalUtilities.getMasterFilePath(), 0, true, 5, "", "", true, Microsoft.Office.Interop.Excel.XlPlatform.xlWindows, "\t", false, false, 0, true, 1, 0);
            Excel.Worksheet xlWorksheet = (Excel.Worksheet)xlWorkbook.Worksheets.get_Item(1);
            Excel.Range xlRange = xlWorksheet.UsedRange;

            int row = xlRange.Rows.Count;
            int col = xlRange.Columns.Count;
            string eanCodePlaceholder = "";

            for(int rowCount = 1; rowCount <= row; rowCount++)
            {
                // Creating a list to contain the excel data
                List<string> productListInfo = new List<string>();

                for(int colCount = 1; colCount <= col; colCount++)
                {
                    /* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
                     * Legend:                                                                                                       *
                     * Material #   | Material Description      | Selling Price     | Discount       | EAN Code     | Quantity       *
                     * --------------------------------------------------------------------------------------------------------------*
                     * column 1     | colum 2                   | column 3          | column 4       | column 5     | column6        *
                     * type double  | type string               | type double       | type double    | type double  | {null} no input*
                     * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * */
                    
                    // Stores data into dictionary
                    Object obj = (xlRange.Cells[rowCount, colCount] as Excel.Range).Value;
                    if(colCount == 5) // EAN Code, to be used in the dictionary
                    {
                        eanCodePlaceholder = obj.ToString();
                    }
                    else // Material #, Material Description, Selling Price, Discount, and Quantity
                    {
                        if (colCount == 6)
                        {
                            productListInfo.Add("0");
                        }
                        else if (obj != null)
                        {
                            productListInfo.Add(obj.ToString());
                        }
                    }
                }
                GlobalUtilities.addToDictionary(GlobalUtilities.MASTER, eanCodePlaceholder, productListInfo);
            }

            this.Close();
            CashierAndEventInfo cashierAndEventInfo = new CashierAndEventInfo();
            cashierAndEventInfo.ShowDialog();
        }
    }
}
