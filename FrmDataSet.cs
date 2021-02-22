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
    public partial class FrmDataSet : Form
    {
        DataSet ds = new DataSet();
        public SqlConnection conn = new SqlConnection("server=.;database=MySchool;uid=sa;pwd=sa;");
        SqlDataAdapter sda = null;
        public FrmDataSet()
        {
            InitializeComponent();
        }

        private void FrmDataSet_Load(object sender, EventArgs e)
        {
            LoadGrade();
            LoadAllStudent();
        }
        public void LoadGrade()
        {
            string sql = "select GradeId,GradeName from Grade";
            SqlDataAdapter sda = new SqlDataAdapter(sql, conn);
            sda.Fill(ds, "Grade");

            clGrade.DataSource = ds.Tables["Grade"];
            clGrade.ValueMember = "GradeId";
            clGrade.DisplayMember = "GradeName";
        }
        public void LoadAllStudent()
        {
            string sql = "select studentNo,studentName,LoginPwd,Gender,Phone,Birthday,GradeId from Student";
            sda = new SqlDataAdapter(sql, conn);

            if (ds.Tables["Student"] != null)
                ds.Tables["Student"].Clear();

            sda.Fill(ds,"Student");

            dgvStudents.DataSource = ds.Tables["Student"];

        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            SqlCommandBuilder scb = new SqlCommandBuilder(sda);
            sda.Update(ds.Tables["Student"]);

            LoadAllStudent();
        }
    }
}
