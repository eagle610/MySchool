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
    public partial class FrmSearch : Form
    {
        string connString = "server=.;database=MySchool;uid=sa;pwd=sa;";
        DBHelper db = new DBHelper();
        public FrmSearch()
        {
            InitializeComponent();
        }

        private void FrmSearch_Load(object sender, EventArgs e)
        {
            LoadGrades();
            LoadStudent();
        }

        public void LoadStudent()
        {
            lvStudents.Items.Clear();//清空项

            string sql = "select [StudentNo], [StudentName], [Gender],s.[GradeId], [Address],g.GradeName from Student s join Grade g on s.GradeId=g.GradeId where 1=1 ";
            if (txtStudentName.Text.Trim() != "")
            {
                sql += " and StudentName like '%" + txtStudentName.Text.Trim() + "%'";
            }
            if (rdAll.Checked == false)
            {
                sql += " and Gender=" + (rdNan.Checked == true ? "1" : "0");
            }
            if (cboGrade.SelectedIndex > 0)
            {
                sql += string.Format(" and GradeName ='{0}'", cboGrade.Text);
            }
            SqlConnection conn = new SqlConnection(connString);
            conn.Open();

            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                //创建列表主项目对象
                ListViewItem item = new ListViewItem(sdr["StudentNo"].ToString());
                //添加子项
                item.SubItems.AddRange(new string[] {
                    sdr["StudentName"].ToString(),
                    sdr["Gender"].ToString()=="1"?"男":"女",
                    sdr["GradeName"].ToString(),
                    sdr["Address"].ToString()
                });
                lvStudents.Items.Add(item);
            }
            sdr.Close();
            conn.Close();
        }

        public void LoadGrades()
        {
            string sql = "select gradeId,gradeName from Grade";
            SqlConnection conn = new SqlConnection(connString);
            conn.Open();

            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader sdr = cmd.ExecuteReader();

            cboGrade.Items.Add("--全部--");
            while (sdr.Read())
            {
                cboGrade.Items.Add(sdr["GradeName"]);
            }
            cboGrade.SelectedIndex = 0;
            sdr.Close();
            conn.Close();
        }
        private void BtnSearch_Click(object sender, EventArgs e)
        {
            LoadStudent();
        }

        private void TsmiDelete_Click(object sender, EventArgs e)
        {
            if (lvStudents.SelectedItems.Count == 0)//判断是否选中项
            {
                MessageBox.Show("请选择要删除的学生！", "操作提示");
                return;
            }

            if (MessageBox.Show("是否要删除学生？", "删除提示", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                //获取学号
                string studentNo = lvStudents.SelectedItems[0].Text;
                //string studentName = lvStudents.SelectedItems[0].SubItems[1].Text;

                string sql = "delete Student where studentNo=" + studentNo;

                if (db.ExecuteNonQuery(sql) > 0)
                {
                    MessageBox.Show("删除成功！");

                    LoadStudent();//刷新界面
                }
                else
                {
                    MessageBox.Show("删除失败！");
                }

                /* SqlConnection conn = new SqlConnection(connString);
                 conn.Open();

                 SqlCommand cmd = new SqlCommand(sql, conn);
                 if (cmd.ExecuteNonQuery() > 0)
                 {
                     MessageBox.Show("删除成功！");

                     LoadStudent();//刷新界面
                 }
                 else
                 {
                     MessageBox.Show("删除失败！");
                 }*/

                //conn.Close();
            }


        }

        private void TsmiUpdate_Click(object sender, EventArgs e)
        {
            if (lvStudents.SelectedItems.Count == 0)//判断是否选中项
            {
                MessageBox.Show("请选择要修改的学生！", "操作提示");
                return;
            }
            //获取要修改学生的学号
            string studentNo = lvStudents.SelectedItems[0].Text;

            FrmEditStudent frm = new FrmEditStudent();
            frm.MdiParent = this.MdiParent;
            frm.studentNo = studentNo;//传递学号
            frm.frmSearch = this;
            frm.Show();

        }
    }
}
