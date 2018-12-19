using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace ImageProcessingSystem
{
    /// <summary>
    /// 数据库工具类
    /// </summary>
    public class SqlHelper
    {
        #region 获取数据库连接
        private static string GetConnectionString
        {
            get
            {
                return "Data Source=.;Initial Catalog=TestFaceDB;Integrated Security=True"; //转换成string类型
            }
        }
        #endregion

        
        public static SqlDataReader ExcuteReader(string sql, CommandType type, params SqlParameter[] param)
        {
            SqlConnection conn = new SqlConnection(GetConnectionString);
            SqlCommand cmd = new SqlCommand(sql, conn);
            PreaPareCommand(sql, conn, cmd, type, param);
            //参数是关闭连接
            return cmd.ExecuteReader(CommandBehavior.CloseConnection);
        }
        

        #region DataSet
        public static DataSet ExexuteDataset(string sql, CommandType type, params SqlParameter[] param)
        {
            using (SqlConnection conn = new SqlConnection(GetConnectionString))
            {
                SqlCommand cmd = new SqlCommand(sql, conn);
                PreaPareCommand(sql, conn, cmd, type, param);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                return ds;
            }
        }
        #endregion


        #region 查询返回一条记录
        /// <summary>
        /// 查询返回一条记录
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="type"></param>
        /// <param name="param"></param>
        /// <returns></returns>
        public static Object ExecuteScalar(string sql, CommandType type, params SqlParameter[] param)
        {
            using (SqlConnection conn = new SqlConnection(GetConnectionString))
            {
                SqlCommand cmd = new SqlCommand(sql, conn);
                PreaPareCommand(sql, conn, cmd, type, param);
                return cmd.ExecuteScalar();
            }
        }
        #endregion

        #region 命令对象装配
        //命令对象装配
        private static void PreaPareCommand(string sql, SqlConnection conn, SqlCommand cmd, CommandType type, params SqlParameter[] param)
        {
            if (conn.State != ConnectionState.Open)
            {
                conn.Close();
                conn.Open();
            }
            cmd.CommandType = type;
            if (param != null)
            {
                foreach (SqlParameter p in param)
                {
                    cmd.Parameters.Add(p);
                }
            }
        }
        #endregion

        #region 增删改
        public static int ExecuteNonQuery(string sql, CommandType type, params SqlParameter[] param)
        {
            using (SqlConnection conn = new SqlConnection(GetConnectionString))
            {
                SqlCommand cmd = new SqlCommand(sql, conn);
                PreaPareCommand(sql, conn, cmd, type, param);
                return cmd.ExecuteNonQuery();
            }
        }
        #endregion

    }
}
