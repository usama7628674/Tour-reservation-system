using Tour_Reservation_System.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tour_Reservation_System.DL
{
    class TerminalDL
    {
         DBConnection dbconn;

         public TerminalDL()
        {
            dbconn = new DBConnection();
        }

         public int InsertTerminalInDB(TerminalDTO terminalDTO)
        {
            try
            {
                dbconn.Con.Open();
          
                String insertDonorQuery = "insert into Terminal (terminal_city) values (@City)";
                SqlCommand com = new SqlCommand(insertDonorQuery, dbconn.Con);

                com.Parameters.AddWithValue("@City", terminalDTO.TerminalCity);
               
                int rowAffected = com.ExecuteNonQuery();
                return rowAffected;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                dbconn.Con.Close();
            }

        }
         public DataSet FetchAllFromDB()
         {
             try
             {

                 SqlCommand cmd = new SqlCommand();
                 string query = "select * from Terminal";
                 cmd.Connection = dbconn.Con;
                 cmd.CommandText = query;

                 SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                 DataSet dataSet = new DataSet();

                 adapter.Fill(dataSet);
                 return dataSet;
             }
             catch (SqlException e)
             {
                 throw e;
             }
         }
    }
}
