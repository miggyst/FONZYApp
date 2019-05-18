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
	public partial class SaleDetails : Form
	{
		public SaleDetails()
		{
			InitializeComponent();
		}

        /// <summary>
        /// On form load, disable SaleDetails form and load ChooseApplication
        /// to proceed with the workflow.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaleDetails_Load(object sender, EventArgs e)
        {
            ChooseApplication chooseApplication = new ChooseApplication();
            chooseApplication.ShowDialog();
            addProduct.Focus();
        }
        
        private void ProcessButton_Click(object sender, EventArgs e)
        {
            //NEED TO DISABLE PROCESS BUTTON WHEN THERE ISN'T ANY DATA INSIDE DataGridView
            CodeDetails codeDetails = new CodeDetails();
            codeDetails.ShowDialog();
        }
    }
}
