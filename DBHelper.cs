using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace MySchool
{
    public class DBHelper
    {
        //连接字符串
        private const string connString = "server=.;database=MySchool;uid=sa;pwd=sa;";

        private SqlConnection conn = null;
        public SqlConnection Conn
        {
            get
            {
                if (conn == null)
                {
                    conn = new SqlConnection(connString);
                    conn.Open();
                }
                else if (conn.State == ConnectionState.Broken)
                {
                    //连接状态为中断，则先关闭连接，再打开连接
                    conn.Close();
                    conn.Open();
                }
                else if (conn.State == ConnectionState.Closed)
                {
                    //如果连接状态为关闭，则直接打开
                    conn.Open();
                }
                return conn;
            }
        }

        /// <summary>
        /// 关闭连接对象
        /// </summary>
        public void CloseConnection()
        {
            if (conn != null)
            {
                //状态为打开或中断，则需要关闭
                if (conn.State == ConnectionState.Open || conn.State == ConnectionState.Broken)
                {
                    conn.Close();
                }
            }
        }

        /// <summary>
        /// 实现增，删，改操作
        /// </summary>
        /// <param name="sql">实现操作的SQL语句</param>
        /// <param name="sqlParams">sql语句中的参数列表</param>
        /// <returns>受影响行数</returns>
        public int ExecuteNonQuery(string sql, params SqlParameter[] sqlParams)
        {
            try //捕获异常，将可能出现异常的代码放入其中，不能单独出现
            {
                //创建执行对象 
                SqlCommand cmd = GetSqlCommand(sql, sqlParams);

                return cmd.ExecuteNonQuery();//执行且返回影响行数
            }
            catch (Exception ex)//当try里面的代码出现异常，则会执行catch里面的代码，如果无异常则不会执行
            {
                Console.WriteLine(ex.Message);
                return -1;
            }
            finally //不管是否有异常都会执行
            {
                this.CloseConnection();//关闭连接
            }
        }

        private SqlCommand GetSqlCommand(string sql, SqlParameter[] sqlParams)
        {
            SqlCommand cmd = new SqlCommand(sql, Conn);
            if (sqlParams != null)
            {
                //添加参数到执行对象中
                //cmd.Parameters.AddRange(sqlParams);
                foreach (var param in sqlParams)
                {
                    cmd.Parameters.Add(param);
                }
            }

            return cmd;
        }

        /// <summary>
        /// 返回单行单列的对象
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="sqlParams"></param>
        /// <returns></returns>
        public object ExecuteScalar(string sql, params SqlParameter[] sqlParams)
        {
            try //捕获异常，将可能出现异常的代码放入其中，不能单独出现
            {
                //创建执行对象 
                SqlCommand cmd = GetSqlCommand(sql, sqlParams);
                return cmd.ExecuteScalar();
            }
            catch (Exception ex)//当try里面的代码出现异常，则会执行catch里面的代码，如果无异常则不会执行
            {
                Console.WriteLine(ex.Message);
                return null;
            }
            finally //不管是否有异常都会执行
            {
                this.CloseConnection();//关闭连接
            }
        }
        /// <summary>
        /// 实现多行查询操作
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="sqlParams"></param>
        /// <returns></returns>
        public SqlDataReader ExecuteReader(string sql, params SqlParameter[] sqlParams)
        {
            try //捕获异常，将可能出现异常的代码放入其中，不能单独出现
            {
                //创建执行对象 
                SqlCommand cmd = GetSqlCommand(sql, sqlParams);
                return cmd.ExecuteReader(CommandBehavior.CloseConnection);//当关闭对象时，则自动关闭连接对象 
            }
            catch (Exception ex)//当try里面的代码出现异常，则会执行catch里面的代码，如果无异常则不会执行
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }
        /// <summary>
        /// 返回操作表
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="tableName"></param>
        /// <param name="sqlParams"></param>
        /// <returns></returns>
        public DataTable GetTable(string sql, string tableName = "", params SqlParameter[] sqlParams)
        {
            DataSet ds = new DataSet();

            try
            {
                //创建执行对象 
                SqlCommand cmd = GetSqlCommand(sql, sqlParams);

                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(ds, tableName);

                return ds.Tables[0];
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }
    }
}
