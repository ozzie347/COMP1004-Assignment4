using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP1004_Assignment4
{
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();
        }

        private void splashScreenTimer_Tick(object sender, EventArgs e)
        {
            splashScreenTimer.Stop();

            StartForm startForm = new StartForm();

            Hide();

            startForm.Show();
        }
    }
}
