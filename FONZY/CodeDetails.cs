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
            this.Close()
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
            PaymentType paymentType = new PaymentType();
            paymentType.ShowDialog();
        }
    }
}
