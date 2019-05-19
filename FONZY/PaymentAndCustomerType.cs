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
        /// disables the proceed button on load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PaymentAndCustomerType_Load(object sender, EventArgs e)
        {
            paymentAndCustomerTypeButton.Enabled = false;

        }

        /// <summary>
        /// payment and customer type button stores the user data input check box,
        /// then redirects the user to the calculator form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PaymentAndCustomerTypeButton_Click(object sender, EventArgs e)
        {
            // Stores payment type in GlobalUtilities
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

            // Stores customer type in GlobalUtilities
            GlobalUtilities.setCustomerType(customerTypeGroupBox.Controls.OfType<RadioButton>().SingleOrDefault(n => n.Checked == true).Text);

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

        /// <summary>
        /// disables the proceed button when there is no checked box
        /// within the paymentTypeCheckBox,
        /// it also enables the proceed button if there are at least 1 checked box for each
        /// customerTypeCheckBox and paymentTypeCheckBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PaymentTypeCheckBox_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.NewValue == CheckState.Unchecked)
            {
                paymentAndCustomerTypeButton.Enabled = false;
            }
            else
            {
                paymentAndCustomerTypeButton.Enabled = true;
            }
}
    }
}
