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
            // store data in global utilities
            this.Close();
            PaymentCalculator paymentCalculator = new PaymentCalculator();
            paymentCalculator.ShowDialog();
        }
    }
}
