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
    public partial class FrmMain : Form
    {
        public string studentName = "";

        /* public FrmMain()
         {
             InitializeComponent();

         }*/
        public FrmMain(string studentName = "")
        {
            InitializeComponent();

            this.Text = "欢迎【" + studentName + "】";
        }
        private void FrmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();//退出应用程序
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("是否要退出系统！", "退出提示", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;//取消事件执行
            }
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            //this.Text = "欢迎【" + studentName + "】";

            this.Text = "欢迎【" + Temp.userName + "】";
        }

        private void TsmiExit_Click(object sender, EventArgs e)
        {
            Application.Exit();//退出应用程序
        }

        private void TsmiAddStudent_Click(object sender, EventArgs e)
        {
            FrmEditStudent frm = new FrmEditStudent();
            frm.MdiParent = this;//设置父容器为本窗体
            frm.Show();
        }

        private void TsmiSearch_Click(object sender, EventArgs e)
        {
            FrmSearch frm = new FrmSearch();
            frm.MdiParent = this;
            frm.Show();
        }

        private void TsmiAbout_Click(object sender, EventArgs e)
        {
            FrmAbout frm = new FrmAbout();
            // frm.MdiParent = this;//不允许通过MDI方式 打开
            frm.ShowDialog();//以模式窗体打开
        }
    }
}
