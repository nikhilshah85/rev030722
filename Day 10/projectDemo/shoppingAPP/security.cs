using System;
using System.Data.SqlClient;

namespace shoppingAPP
{
    class Security
    {
           public bool Login(string uName,string pwd)
          {
             SqlConnection con = new SqlConnection(@"server=DESKTOP-H5HFUEB\TRAINERINSTANCE;database=shoppingAPP;integrated security=true");
             SqlCommand cmd_login = new SqlCommand("select count(*) from login where username=@uName and password=@pwd",con);

             cmd_login.Parameters.AddWithValue("@uName",uName);
             cmd_login.Parameters.AddWithValue("@pwd",pwd);

             try
             {
                 con.Open();
                 int cridential_count =(int) cmd_login.ExecuteScalar();
                 if (cridential_count > 0)
                 {
                     return true;
                 }
                 else
                 {
                     return false;
                 }
             }
             catch (System.Exception es)
             {
                 
                 throw new Exception(es.Message);
             }
             finally
             {
                 con.Close();
             }
        }
    }
}