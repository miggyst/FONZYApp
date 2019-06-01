using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FONZY
{
    public partial class InventorySaleDetails : Form
    {
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
            List<string> keyList = new List<string>(GlobalUtilities.getMasterListDictionary().Keys);

            //GlobalUtilities.setTotalQuantity((Int32.Parse(GlobalUtilities.getTotalQuantity()) + Int32.Parse(quantityNumericUpDown.Value.ToString())).ToString());

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

        }

        private void ProcessButton_Click(object sender, EventArgs e)
        {
            
        }
    }
}
