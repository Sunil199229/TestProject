using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace dynamicField.Views
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //deriverdClass dv = new deriverdClass();
            //deriverdClass dv1 = new deriverdClass(25);

            //SqlConnection sqlcon = new SqlConnection("initial catalog = AnkitPractice; user id = sa; password = odpserver550810998@; data source = occweb05");
            //sqlcon.Open();
            //SqlCommand sqlcmd = new SqlCommand();
            //sqlcmd.Connection = sqlcon;
            //sqlcmd.CommandType = CommandType.Text;
            ////sqlcmd.CommandText = "update MstCity set CityRemark = 'aaa1' where citycode between 16 and 19";
            ////int rowcount = sqlcmd.ExecuteNonQuery();
            ////sqlcmd.CommandText = "select * from  MstCity where citycode > 5";
            //sqlcmd.CommandText = "insert into MstCity values (1001002,'b','b')";
            //object rowcount = sqlcmd.ExecuteScalar();
            //sqlcon.Close();

            SqlConnection sqlcon;
            using (sqlcon = new SqlConnection("initial catalog = AnkitPractice; user id = sa; password = odpserver550810998@; data source = occweb05;"))
            {

                string query = "select * from  MstCity where citycode > 5";
                sqlcon.Open();
                //SqlTransaction sqltran = sqlcon.BeginTransaction("tran1");
                SqlCommand sqlcmd = new SqlCommand(); //query, sqlcon, sqltran
                SqlCommand sqlcmd1 = new SqlCommand();
                sqlcmd.Connection = sqlcon;
                sqlcmd1.Connection = sqlcon;
                //sqlcmd.Transaction = sqltran;
                sqlcmd.CommandType = CommandType.Text;
                sqlcmd1.CommandType = CommandType.Text;
                //sqlcmd.CommandText = "update MstCity set CityRemark = 'aaa1' where citycode between 16 and 19";
                //int rowcount = sqlcmd.ExecuteNonQuery();
                //sqlcmd.CommandText = "select * from  MstCity where citycode > 5";
                //sqlcmd.CommandText = "insert into MstCity values (1001002,'b','b')";
                //SqlDataAdapter sqlda = new SqlDataAdapter(sqlcmd);
                DataTable dt = new DataTable();
                //int rowcount1 = sqlcmd.ExecuteNonQuery();
                sqlcmd.CommandText = "insert into MstCity values (1001003,'b','b')";
                sqlcmd1.CommandText = "update MstCity set CityRemark = 'aaa2' where citycode = 2";
                int rowcount = sqlcmd.ExecuteNonQuery();
                int rowcount1 = sqlcmd1.ExecuteNonQuery();
                //sqltran.Save("sv1");
                if (rowcount > 0)
                {
                    //sqltran.Commit();
                }
                else
                {
                    //sqltran.Rollback();
                    //sqltran.Rollback("sv1");
                }
                sqlcon.Close();
                //sqlda.Fill(dt);
                //object rowcount = sqlcmd.ExecuteScalar();
            }
        }
    }
}