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
	public partial class PaymentCalculator : Form
	{
		public PaymentCalculator()
		{
			InitializeComponent();
		}

        /// <summary>
        /// proceed button lets the user to go forth with the workflow
        /// and allows the user to double check and print out an invoice
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ProceedButton_Click(object sender, EventArgs e)
        {
            this.Close();

            // Initializes variables passed onto MessageBox
            DialogResult validatePaymentDialogResult;
            string validatePaymentMessage = "Are ready to process the transaction?";
            string validatePaymentCaption = "User Validation";
            MessageBoxButtons messageBoxButtons = MessageBoxButtons.YesNo;

            // Displays the MessageBox and checks response
            validatePaymentDialogResult = MessageBox.Show(validatePaymentMessage, validatePaymentCaption, messageBoxButtons);
            if (validatePaymentDialogResult == System.Windows.Forms.DialogResult.Yes)
            {
                PrinterDetails printerDetails = new PrinterDetails();
                printerDetails.ShowDialog();
            }
            else
            {
                // Do nothing, returns to SaleDetails form
            }
        }
    }
}
