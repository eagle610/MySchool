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
    public partial class FrmSelectStudentByGrade : Form
    {
        //创建此窗体通用的数据集
        DataSet ds = new DataSet();
        DBHelper db = new DBHelper();

        SqlConnection conn = new SqlConnection("server=.;database=MySchool;uid=sa;pwd=sa;");
        public FrmSelectStudentByGrade()
        {
            InitializeComponent();
            dgvStudents.AutoGenerateColumns = false;//关闭自动生成列
        }

        private void FrmSelectStudentByGrade_Load(object sender, EventArgs e)
        {
            LoadGrade();

            clGrade.DataSource = ds.Tables["Grade"];
            clGrade.ValueMember = "GradeId";
            clGrade.DisplayMember = "GradeName";
        }
        public void LoadGrade()
        {

            string sql = "select GradeId,GradeName from Grade";
            /*//创建适配器
            SqlDataAdapter sda = new SqlDataAdapter(sql, conn);
            //填充数据集
            sda.Fill(ds, "Grade");

            DataRow dr = ds.Tables["Grade"].NewRow();//创建一个行的对象
            dr["GradeId"] = -1;//指定列
            dr["GradeName"] = "--全部--";

            //将行插入到表中



            ds.Tables["Grade"].Rows.InsertAt(dr, 0);*/

            DataTable dt = db.GetTable(sql);

            DataRow dr = dt.NewRow();//创建一个行的对象
            dr["GradeId"] = -1;//指定列
            dr["GradeName"] = "--全部--";

            //将行插入到表中



            dt.Rows.InsertAt(dr, 0);

            //绑定数据源
            cboGrade.DataSource = dt;
            cboGrade.ValueMember = "GradeId";//指定值的列
            cboGrade.DisplayMember = "GradeName";//显示的列
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            /* object obj = cboGrade.SelectedValue;
             int selectedIndex = cboGrade.SelectedIndex;
             string text = cboGrade.Text;*/

            string sql = "select StudentNo, LoginPwd, StudentName, Gender, GradeId, Phone, Address, Birthday, Email from Student where 1=1 ";
            if ((int)cboGrade.SelectedValue > 0)
            {
                sql += " and GradeId=" + cboGrade.SelectedValue;
            }
            SqlDataAdapter sda = new SqlDataAdapter(sql, conn);

            //填充前清空之前的数据
            if (ds.Tables["Student"] != null)
                ds.Tables["Student"].Clear();

            sda.Fill(ds, "Student");

            dgvStudents.DataSource = ds.Tables["Student"];

            for (int i = 0; i < dgvStudents.Rows.Count; i++)
            {
                dgvStudents.Rows[i].Cells["clGender"].Value = dgvStudents.Rows[i].Cells["clGender"].Value.ToString() == "1" ? "男" : "女";
            }
        }

        private void TsmiDelete_Click(object sender, EventArgs e)
        {
            //获取学号
            string studentNo = dgvStudents.SelectedRows[0].Cells["clStudentNo"].Value.ToString();
            string studentName = dgvStudents.SelectedRows[0].Cells["clStudentName"].Value.ToString();

        }
    }
}
