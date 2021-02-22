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
    public partial class FrmEditStudent : Form
    {
        string connString = "server=.;database=MySchool;uid=sa;pwd=sa;";

        public string studentNo = "";//保存学号，修改时传递过来的学号
        public FrmSearch frmSearch = null;//查询窗体 
             
        public FrmEditStudent()
        {
            InitializeComponent();
        }

        public void LoadGrade()
        {
            string sql = "select GradeId,GradeName from Grade;";
            SqlConnection conn = new SqlConnection(connString);
            conn.Open();

            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader sdr = cmd.ExecuteReader();

            cboGrade.Items.Add("--请选择--");
            while (sdr.Read())
            {
                cboGrade.Items.Add(sdr["GradeName"]);
            }
            cboGrade.SelectedIndex = 0;//选中第一个
            sdr.Close();
            conn.Close();
        }
        public bool CheckInput()
        {
            if (cboGrade.SelectedIndex == 0)
            {
                MessageBox.Show("请选择年级！");
                return false;
            }
            return true;
        }

        public int GetGradeIdByGradeName(string gradeName)
        {
            string sql = "select gradeId from Grade where GradeName=@GradeName";
            SqlConnection conn = new SqlConnection(connString);
            conn.Open();
            SqlParameter sp = new SqlParameter("@GradeName", gradeName);
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.Add(sp);
            int gradeId = (int)cmd.ExecuteScalar();

            conn.Close();
            return gradeId;

        }

        private void FrmEditStudent_Load(object sender, EventArgs e)
        {
            LoadGrade();

            if (studentNo != "")
            {
                //修改操作才加载信息
                LoadStudentInfoByNo();
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (CheckInput())//验证
            {
                if (txtStudentNo.Text == "")
                {
                    //实现添加功能
                    string sql = "insert into Student ( LoginPwd, StudentName, Gender, GradeId, Phone, Address, Birthday, Email) values(@LoginPwd, @StudentName, @Gender, @GradeId, @Phone, @Address, @Birthday, @Email);select @@IDENTITY;";
                    SqlConnection conn = new SqlConnection(connString);
                    conn.Open();
                    SqlParameter[] sp =
                    {
                        new SqlParameter("@LoginPwd",txtPwd.Text),
                        new SqlParameter("@StudentName",txtName.Text),
                        new SqlParameter("@Gender",rdoNan.Checked==true?"1":"0"),
                        new SqlParameter("@GradeId",GetGradeIdByGradeName(cboGrade.Text)),
                        new SqlParameter("@Phone",txtPhone.Text),
                        new SqlParameter("@Address",txtAddress.Text),
                        new SqlParameter("@Birthday",dtpBorndate.Value),
                        new SqlParameter("@Email",txtEmail.Text)
                     };
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddRange(sp);

                    object studentNo = cmd.ExecuteScalar();
                    if (studentNo != null)
                    {
                        MessageBox.Show("添加学员信息成功！");
                        txtStudentNo.Text = studentNo + "";
                    }
                    else
                    {
                        MessageBox.Show("添加学员信息失败！");
                    }
                    /* int count = cmd.ExecuteNonQuery();

                     if (count > 0)
                     {
                         MessageBox.Show("添加学员信息成功！");
                     }
                     else
                     {
                         MessageBox.Show("添加学员信息失败！");
                     }*/
                    conn.Close();

                }
                else
                {
                    //实现添加功能
                    string sql = "update Student set LoginPwd=@LoginPwd, StudentName=@StudentName, Gender=@Gender, GradeId=@GradeId, Phone=@Phone, Address=@Address, Birthday=@Birthday, Email=@Email where StudentNo=@StudentNo";
                    SqlConnection conn = new SqlConnection(connString);
                    conn.Open();
                    SqlParameter[] sp =
                    {
                        new SqlParameter("@LoginPwd",txtPwd.Text),
                        new SqlParameter("@StudentName",txtName.Text),
                        new SqlParameter("@Gender",rdoNan.Checked==true?"1":"0"),
                        new SqlParameter("@GradeId",GetGradeIdByGradeName(cboGrade.Text)),
                        new SqlParameter("@Phone",txtPhone.Text),
                        new SqlParameter("@Address",txtAddress.Text),
                        new SqlParameter("@Birthday",dtpBorndate.Value),
                        new SqlParameter("@Email",txtEmail.Text),
                        new SqlParameter("@StudentNo",txtStudentNo.Text)
                     };
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddRange(sp);

                    int count = cmd.ExecuteNonQuery();
                    if (count > 0)
                    {
                        MessageBox.Show("修改学员信息成功！");

                        frmSearch.LoadStudent();

                    }
                    else
                    {
                        MessageBox.Show("修改学员信息失败！");
                    }

                    conn.Close();
                }
            }
        }


        public void LoadStudentInfoByNo()
        {
            string sql = "select LoginPwd, StudentName, Gender, s.GradeId, Phone, Address, Birthday, Email,GradeName from Student s join Grade g on s.GradeId=g.GradeId where StudentNo=" + studentNo;
            SqlConnection conn = new SqlConnection(connString);
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader sdr = cmd.ExecuteReader();

            if (sdr.Read())
            {
                txtStudentNo.Text = studentNo;
                txtPwd.Text = txtRePwd.Text = sdr["LoginPwd"].ToString();
                txtName.Text = sdr["StudentName"].ToString();
                txtAddress.Text = sdr["Address"].ToString();
                txtEmail.Text = sdr["Email"].ToString();
                txtPhone.Text = sdr["Phone"].ToString();
                rdoNan.Checked = sdr["Gender"].ToString() == "1";
                rdoNv.Checked = sdr["Gender"].ToString() == "0";
                cboGrade.Text = sdr["GradeName"].ToString();
                dtpBorndate.Text = sdr["Birthday"].ToString();
            }
            sdr.Close();
            conn.Close();
        }

    }
}
