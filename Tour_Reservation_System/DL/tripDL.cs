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
    class tripDL
    {
        DBConnection dbconn;

        public tripDL()
        {
            dbconn = new DBConnection();
        }

        public int InsertBusInDB(tripDTO busDTO)
        {
            try
            {
                dbconn.Con.Open();

                String insertDonorQuery = "insert into trip (trip_name, trip_class, trip_people_capacity) values (@BusNumber, @BusClass, @BusSeater)";
                SqlCommand com = new SqlCommand(insertDonorQuery, dbconn.Con);

                com.Parameters.AddWithValue("@BusNumber", busDTO.BusNumber);
                com.Parameters.AddWithValue("@BusSeater", busDTO.BusSeater);
                com.Parameters.AddWithValue("@BusClass", busDTO.BusClass);
               
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
                string query = "select * from trip";
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
