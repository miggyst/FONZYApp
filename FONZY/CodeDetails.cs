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
	public partial class CodeDetails : Form
	{
		public CodeDetails()
		{
			InitializeComponent();
		}

        /// <summary>
        /// exit button closes the window and returns to SaleDetails page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// proceed button takes the user input on the given fields,
        /// stores it into global utilities, to be used later,
        /// and moves to PaymentType form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ProceedButton_Click(object sender, EventArgs e)
        {
            this.Close();
            GlobalUtilities.setCustomerTIN(tinTextBox.Text);
            GlobalUtilities.setCustomerBusinessStyle(businessStyleTextBox.Text);
            GlobalUtilities.setCustomerTerms(termsTextBox.Text);
            GlobalUtilities.setCustomerOSCA(oscaTextBox.Text);
            PaymentAndCustomerType paymentAndCustomerType = new PaymentAndCustomerType();
            paymentAndCustomerType.ShowDialog();
        }

        /// <summary>
        /// resets payment identifiers used in PaymentCalculator form upon form closing
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CodeDetails_FormClosing(object sender, FormClosingEventArgs e)
        {
            GlobalUtilities.resetPaymentIdentifiers();
        }
    }
}
