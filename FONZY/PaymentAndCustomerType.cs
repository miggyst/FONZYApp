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
	public partial class PaymentAndCustomerType : Form
	{
		public PaymentAndCustomerType()
		{
			InitializeComponent();
		}

        /// <summary>
        /// payment and customer type button stores the user data input check box,
        /// then redirects the user to the calculator form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PaymentAndCustomerTypeButton_Click(object sender, EventArgs e)
        {
            // Gets the checked boxes for Payment Type and stores it to global utilities
            // If empty, default is cash
            if (paymentTypeCheckBox.CheckedIndices.Count > 0)
            {
                for(int i = 0; i < paymentTypeCheckBox.CheckedIndices.Count; i++)
                {
                    switch (paymentTypeCheckBox.CheckedIndices[i])
                    {
                        case 0: // Cash
                            GlobalUtilities.setCashPaymentIdentifier(true);
                            break;

                        case 1: // Credit
                            GlobalUtilities.setCreditPaymentIdentifier(true);
                            break;

                        case 2: // Debit
                            GlobalUtilities.setDebitPaymentIdentifier(true);
                            break;

                        case 3: // Check
                            GlobalUtilities.setCheckPaymentIdentifier(true);
                            break;

                        case 4: // Salary Deduction
                            GlobalUtilities.setSalaryDeductionPaymentIdentifier(true);
                            break;
                    }
                }
            }
            else
            {
                // Default set to payment type of Cash
                GlobalUtilities.setCashPaymentIdentifier(true);
            }

            this.Close();
            PaymentCalculator paymentCalculator = new PaymentCalculator();
            paymentCalculator.ShowDialog();
        }

        /// <summary>
        /// closes the form and returns to the SaleDetails form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
