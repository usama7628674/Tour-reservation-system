using Tour_Reservation_System.DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tour_Reservation_System.DL
{
    class LoginDL
    {
        DBConnection dbCon;
        public LoginDL()
        {
            dbCon = new DBConnection();
        }
        public string VerifyUsersFromDB(LoginDTO lg)
        {
            try
            {
                dbCon.Con.Open();
                //string queryString = "SELECT Role FROM MyUser WHERE UserID=@UserID AND Password=@Password;";
                string queryString = "SELECT Role FROM MyUser WHERE UserID='" + lg.UserName + "' AND Password='" + lg.Password + "';";
                SqlCommand com = new SqlCommand(queryString, dbCon.Con);
                SqlDataReader reader = com.ExecuteReader();
                com.Parameters.AddWithValue("@UserID", lg.UserName);
                com.Parameters.AddWithValue("@Password", lg.Password);
                while (reader.Read())
                {
                    return reader["Role"].ToString();

                }
            }
            catch (SqlException ex)
            {
                throw ex;

            }
            finally
            {
                dbCon.Con.Close();

            }
            return null;
        }

    }
}
