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
	public partial class CashierAndEventInfo : Form
	{
		public CashierAndEventInfo()
		{
			InitializeComponent();
		}

        /// <summary>
        /// cashierAndEventButton will store the user input into the global utilities file
        /// for future use, then will be redirected back to SaleDetails form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CashierAndEventButton_Click(object sender, EventArgs e)
        {
            // store cashier and event name in global utilities
            this.Close();
        }
    }
}
