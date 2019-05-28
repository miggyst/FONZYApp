using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
        /// enables or disables the text boxes based on whether or not
        /// the preceeding identifiers were toggled on the PaymentAndCustomerType form,
        /// also disables the proceedButton to force the user to calculate customer's change
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PaymentCalculator_Load(object sender, EventArgs e)
        {
            proceedButton.Enabled = false;
            if (GlobalUtilities.getCashPaymentIdentifier() != true)
            {
                cashTextBox.ReadOnly = true;
            }

            if (GlobalUtilities.getCreditPaymentIdentifier() != true)
            {
                creditTextBox.ReadOnly = true;
            }

            if (GlobalUtilities.getDebitPaymentIdentifier() != true)
            {
                debitTextBox.ReadOnly = true;
            }

            if (GlobalUtilities.getCheckPaymentIdentifier() != true)
            {
                checkTextBox.ReadOnly = true;
            }

            if (GlobalUtilities.getSalaryDeductionPaymentIdentifier() != true)
            {
                salaryDeductionTextBox.ReadOnly = true;
            }

            totalAmountTextBox.Text = String.Format("{0:n}", GlobalUtilities.getTotalCost());
            changeTextBox.Text = "0";
        }

        /// <summary>
        /// resets the read only field of Cash, Credit, Debit, Check, and SalaryDeduction text boxes
        /// when the form is closed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PaymentCalculator_FormClosing(object sender, FormClosingEventArgs e)
        {
            cashTextBox.ReadOnly = false;
            creditTextBox.ReadOnly = false;
            debitTextBox.ReadOnly = false;
            checkTextBox.ReadOnly = false;
            salaryDeductionTextBox.ReadOnly = false;
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
        }

        /// <summary>
        /// checks for user input,
        /// only allows numeric values, one decimal point, and two decimal places
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CashTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Only allows numeric values
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // Only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

            // Only allows two numbers after decimal point
            if (Regex.IsMatch(cashTextBox.Text, @"\.\d\d") && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// checks for user input,
        /// only allows numeric values, one decimal point, and two decimal places
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CreditTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Only allows numeric values
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // Only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

            // Only allows two numbers after decimal point
            if (Regex.IsMatch(creditTextBox.Text, @"\.\d\d") && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// checks for user input,
        /// only allows numeric values, one decimal point, and two decimal places
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DebitTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Only allows numeric values
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // Only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

            // Only allows two numbers after decimal point
            if (Regex.IsMatch(debitTextBox.Text, @"\.\d\d") && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// checks for user input,
        /// only allows numeric values, one decimal point, and two decimal places
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CheckTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Only allows numeric values
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // Only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

            // Only allows two numbers after decimal point
            if (Regex.IsMatch(checkTextBox.Text, @"\.\d\d") && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// checks for user input,
        /// only allows numeric values, one decimal point, and two decimal places
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SalaryDeductionTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Only allows numeric values
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // Only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

            // Only allows two numbers after decimal point
            if (Regex.IsMatch(salaryDeductionTextBox.Text, @"\.\d\d") && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// exit button closes the window and goes back to SaleDetails
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// calculates the customer's change (total amount - customer payment),
        /// this will determine whether or not the cashier can proceed to the next form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CalculateButton_Click(object sender, EventArgs e)
        {
            GlobalUtilities.setCashPayment(cashTextBox.Text);
            GlobalUtilities.setCreditPayment(creditTextBox.Text);
            GlobalUtilities.setDebitPayment(debitTextBox.Text);
            GlobalUtilities.setCheckPayment(checkTextBox.Text);
            GlobalUtilities.setSalaryDeductionPayment(salaryDeductionTextBox.Text);
            GlobalUtilities.setTotalCustomerPayment();
            GlobalUtilities.setTotalChange();

            changeTextBox.Text = String.Format("{0:n}", GlobalUtilities.getTotalChange());
            totalCustomerPaymentTextBox.Text = String.Format("{0:n}", (Double.Parse(GlobalUtilities.getCashPayment()) + Double.Parse(GlobalUtilities.getCreditPayment()) + Double.Parse(GlobalUtilities.getDebitPayment())
                                                + Double.Parse(GlobalUtilities.getCheckPayment()) + Double.Parse(GlobalUtilities.getSalaryDeductionPayment())).ToString());

            if (Double.Parse(GlobalUtilities.getTotalChange()) >= 0)
            {
                proceedButton.Enabled = true;
            }
            else
            {
                proceedButton.Enabled = false;
            }
        }
    }
}
