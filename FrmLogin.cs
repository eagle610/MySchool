using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MySchool
{
    public partial class FrmLogin : Form
    {
        //string connString = "server=.;database=MySchool;uid=sa;pwd=sa;";

        DBHelper db = new DBHelper();
        public FrmLogin()
        {
            InitializeComponent();

        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("登录操作！");
            //MessageBox.Show("是否要登录", "登录提示");
            //MessageBox.Show("是否要登录", "登录提示", MessageBoxButtons.YesNo);
            /*  DialogResult dr = MessageBox.Show("是否要登录", "登录提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

              if (dr == DialogResult.Yes)
              {
                  MessageBox.Show("登录成功！");
              }
              else
              {
                  MessageBox.Show("用户取消登录！");
              }*/

            if (CheckInput())
            {
                //实现登录功能
                string sql = "select count(1) from Admin where LoginId=@UserName and LoginPwd=@pwd";
                SqlParameter[] sp =
               {
                    new SqlParameter("@UserName",txtUserName.Text),
                    new SqlParameter("@pwd",txtPwd.Text)
                };

                if ((int)db.ExecuteScalar(sql, sp) > 0)
                {
                    Temp.userName = txtUserName.Text;//将数据保存临时类中

                    FrmMain frm = new FrmMain();
                    frm.Show();//显示窗体
                    this.Hide();//隐藏窗体
                }
                else
                {
                    MessageBox.Show("登录失败！");
                }

                /* SqlConnection conn = new SqlConnection(connString);
                 conn.Open();

                 SqlParameter[] sp =
                 {
                     new SqlParameter("@UserName",txtUserName.Text),
                     new SqlParameter("@pwd",txtPwd.Text)
                 };

                 SqlCommand cmd = new SqlCommand(sql, conn);
                 cmd.Parameters.AddRange(sp);
                 int count = (int)cmd.ExecuteScalar();

                 if (count > 0)
                 {
                     //创建要打开窗体的对象
                     *//* FrmMain frm = new FrmMain();
                      frm.studentName = txtUserName.Text;//将控件的文本赋值给属性
                      frm.Show();//显示窗体
                      this.Hide();//隐藏窗体*/

                /* FrmMain frm = new FrmMain(txtUserName.Text);

                 frm.Show();//显示窗体
                 this.Hide();//隐藏窗体*//*

                Temp.userName = txtUserName.Text;//将数据保存临时类中

                FrmMain frm = new FrmMain();
                frm.Show();//显示窗体
                this.Hide();//隐藏窗体
            }
            else
            {
                MessageBox.Show("登录失败，账号或密码错误！");
            }*/

            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();//关闭当前窗体
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            //加载事件，针对窗体，当窗体加载时执行，通常用在初始化相关的操作
            cboLoginType.SelectedIndex = 0;

        }

        public bool CheckInput()
        {
            if (txtUserName.Text.Trim() == "")
            {
                MessageBox.Show("用户名不能为空！", "登录提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUserName.Focus();
                return false;
            }
            if (txtPwd.Text.Trim() == "")
            {
                MessageBox.Show("密码不能为空！", "登录提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPwd.Focus();//光标定位
                return false;
            }
            else if (txtPwd.Text.Length < 6 || txtPwd.Text.Length > 15)
            {
                MessageBox.Show("密码长度必须在6-15之间！", "登录提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPwd.Focus();
                txtPwd.SelectAll();//选中所有文本
                return false;
            }
            return true;
        }
    }
}
