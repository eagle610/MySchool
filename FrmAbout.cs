using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MySchool
{
    public partial class FrmAbout : Form
    {
        public FrmAbout()
        {
            InitializeComponent();

            this.Text = DateTime.Now.ToString();
         
        }
        int i = 1;
        private void Timer1_Tick(object sender, EventArgs e)
        {
           
            pbAbout.Image = ilAbout.Images[i];
            i++;
            if (i == 4)
            {
                i = 0;
            }
        }

        private void Timer2_Tick(object sender, EventArgs e)
        {
            lblTimer.Text = DateTime.Now.ToString();
        }

        private void BtnBegin_Click(object sender, EventArgs e)
        {
            timer2.Enabled = true;
        }

        private void BtnStop_Click(object sender, EventArgs e)
        {
            timer2.Enabled = false;
        }
    }
}
