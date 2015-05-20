using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AspStoredProc1
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=saadna-tosh\sqlexpress;Initial Catalog=master;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "SaveID";

            SqlParameter p0 = new SqlParameter();
            p0.ParameterName = "@ID";
            p0.Value = TextBox1.Text;
            cmd.Parameters.Add(p0);

            SqlParameter p1 = new SqlParameter();
            p1.ParameterName = "@Name";
            p1.Value = TextBox2.Text;
            cmd.Parameters.Add(p1);

           

            cmd.Connection = con;
            cmd.ExecuteNonQuery();
        }

       
    }
}