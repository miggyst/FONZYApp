using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            //NEED TO ADD FILE EXPLORER HERE
            //code for now
            this.Close();
            CashierAndEventInfo cashierAndEventInfo = new CashierAndEventInfo();
            cashierAndEventInfo.ShowDialog();
            //Add global utilities call here
        }
    }
}
