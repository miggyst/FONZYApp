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
        /// disables the button on form load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CashierAndEventInfo_Load(object sender, EventArgs e)
        {
            cashierAndEventButton.Enabled = false;
        }

        /// <summary>
        /// validates data on cashier name text box
        /// disables button if null, empty or whitespace on text box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cashierNameTextBoxValidating(object sender, CancelEventArgs e)
        {
            if(string.IsNullOrWhiteSpace(cashierNameTextBox.Text))
            {
                cashierAndEventButton.Enabled = false;
            }
            else
            {
                cashierAndEventButton.Enabled = true;
            }
        }

        /// <summary>
        /// validates data on event name text box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void eventNameTextBoxValidating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(eventNameTextBox.Text))
            {
                cashierAndEventButton.Enabled = false;
            }
            else
            {
                cashierAndEventButton.Enabled = true;
            }
        }

        /// <summary>
        /// cashierAndEventButton will store the user input into the global utilities file
        /// for future use, then will be redirected back to SaleDetails form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CashierAndEventButton_Click(object sender, EventArgs e)
        {
            this.Close();
            GlobalUtilities.setCashierName(cashierNameTextBox.Text);
            GlobalUtilities.setEventName(eventNameTextBox.Text);
        }
    }
}
