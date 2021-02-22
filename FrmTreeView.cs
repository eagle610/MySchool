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
    public partial class FrmTreeView : Form
    {
        SqlConnection conn = new SqlConnection("server=.;database=MySchool;uid=sa;pwd=sa");
        DataSet ds = new DataSet();
        public FrmTreeView()
        {
            InitializeComponent();
        }

        private void FrmTreeView_Load(object sender, EventArgs e)
        {
            dgvStus.AutoGenerateColumns = false;
            tvGrades.ExpandAll();//展开所有节点
            LoadAllStudent();
        }

        private void TvGrades_AfterSelect(object sender, TreeViewEventArgs e)
        {
            /* string text = tvGrades.SelectedNode.Text;//获取选中节点的文本
             int level = tvGrades.SelectedNode.Level;
             if (level == 2)
             {
               string ptext=  tvGrades.SelectedNode.Parent.Text;
             }*/

            /* string sql = "select * from Student s join Grade g on s.GradeId=g.GradeId where 1=1 ";

             if (tvGrades.SelectedNode.Level == 1)
             {
                 sql += " and g.GradeName ='" + tvGrades.SelectedNode.Text + "'";
             }
             else if (tvGrades.SelectedNode.Level == 2)
             {
                 sql += " and Gender=" + (tvGrades.SelectedNode.Text == "男" ? 1 : 0) + " and g.GradeName ='" + tvGrades.SelectedNode.Parent.Text + "'";
             }


             SqlDataAdapter sda = new SqlDataAdapter(sql,conn);

             if (ds.Tables["Student"] != null)
                 ds.Tables["Student"].Clear();

             sda.Fill(ds, "Student");

             dgvStus.DataSource = ds.Tables["Student"];*/

            //创建视图对象
            DataView dv = new DataView(ds.Tables["Student"]);
            if (tvGrades.SelectedNode.Level == 1)
            {
                //条件筛选
                dv.RowFilter = string.Format("GradeName='{0}'", tvGrades.SelectedNode.Text);
            }
            else if (tvGrades.SelectedNode.Level == 2)
            {
                dv.RowFilter = string.Format("GradeName='{0}' and Gender={1}", tvGrades.SelectedNode.Parent.Text,tvGrades.SelectedNode.Text=="男"?1:0);
            }
            dv.Sort = "Gender asc,StudentNo desc";//排序
            dgvStus.DataSource = dv;
        }

        public void LoadAllStudent()
        {
            string sql = "select * from Student s join Grade g on s.GradeId=g.GradeId where 1=1 ";

            SqlDataAdapter sda = new SqlDataAdapter(sql, conn);
            sda.Fill(ds, "Student");
        }
    }
}
