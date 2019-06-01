using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FONZY
{
	public partial class ChooseApplication : Form
	{
		public ChooseApplication()
		{
			InitializeComponent();
		}

        /// <summary>
        /// inventory button that specifies that the application will be in
        /// Inventory Mode, and will be redirected to ChooseMasterFile form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void InventoryButton_Click(object sender, EventArgs e)
        {
            this.Close();
            ChooseMasterFile chooseMasterFile = new ChooseMasterFile(GlobalUtilities.INVENTORY_MODE);
            chooseMasterFile.ShowDialog();
        }

        /// <summary>
        /// transaction button that specifies that the application will be in
        /// Transaction mode, and will be redirected to ChooseMasterFile form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TransactionButton_Click(object sender, EventArgs e)
        {
            this.Close();
            ChooseMasterFile chooseMasterFile = new ChooseMasterFile(GlobalUtilities.TRANSACTION_MODE);
            chooseMasterFile.ShowDialog();
        }
    }
}
