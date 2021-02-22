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
    public partial class FrmQQ : Form
    {
        public FrmQQ()
        {
            InitializeComponent();
        }

        private void BtnBig_Click(object sender, EventArgs e)
        {
            //显示大图标
            lvList.View = View.LargeIcon;
        }

        private void BtnSmall_Click(object sender, EventArgs e)
        {
            //显示小图标
            lvList.View = View.SmallIcon;
        }

        private void BtnXx_Click(object sender, EventArgs e)
        {
            lvList.View = View.Details;
        }
    }
}
