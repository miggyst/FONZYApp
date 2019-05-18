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
    public partial class MainStartup : Form
    {
        public MainStartup()
        {
            InitializeComponent();
        }

        private void MainStartup_Load(object sender, EventArgs e)
        {
            this.Hide();
            ChooseApplication chooseApplication = new ChooseApplication();
            chooseApplication.Show();
        }
    }
}
