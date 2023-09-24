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
    class ReservationDL
    {
         DBConnection dbconn;

         public ReservationDL()
        {
            dbconn = new DBConnection();
        }

         public int InsertReservationInDB(ReservationDTO resDTO)
        {
            try 
            {
                dbconn.Con.Open();

                String insertDonorQuery = "insert into Reservations (customer_name, phone, cnic, trip_people_quantity, from_terminal, to_terminal, travel_date, fare, status, trip_name, trip_class) values (@CustomerName, @Phone, @CNIC, @SeatsQuantity, @FromTerminal, @ToTerminal, @TravelDate, @Fare, @Status, @BusNumber, @BusClass)";
                SqlCommand com = new SqlCommand(insertDonorQuery, dbconn.Con);

                com.Parameters.AddWithValue("@BusNumber", resDTO.BusNumber);               
                com.Parameters.AddWithValue("@BusClass", resDTO.BusClass);
                com.Parameters.AddWithValue("@FromTerminal", resDTO.FromTerminal);
                com.Parameters.AddWithValue("@ToTerminal", resDTO.ToTerminal );
                com.Parameters.AddWithValue("@TravelDate", resDTO.TravelDate );
                com.Parameters.AddWithValue("@CustomerName", resDTO.CustomerName );
                com.Parameters.AddWithValue("@CNIC", resDTO.CNIC);
                com.Parameters.AddWithValue("@SeatsQuantity", resDTO.SeatsQuantity );
                com.Parameters.AddWithValue("@Phone", resDTO.PhoneNumber );
                com.Parameters.AddWithValue("@Fare", resDTO.Fare);
                com.Parameters.AddWithValue("@Status", resDTO.Status);



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

         public DataSet cancelReservationFromDB(ReservationDTO resDTO)
         {
             try 
             {

                 SqlCommand cmd = new SqlCommand();      
                 cmd.Parameters.AddWithValue("@ResID", resDTO.TicketID);
                 cmd.Parameters.AddWithValue("@TravelDate", resDTO.TravelDate);
                 string query = "select * from Reservations where res_id = @ResID AND travel_date = @TravelDate";
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

          public int UpdateCancelInDB(ReservationDTO resDTO)
         {
               
             try
             {
                 dbconn.Con.Open();
                 String UpdateQuery = "update Reservations set status = '" + resDTO.Status + "' Where res_id = " + resDTO.TicketID;
                 
                 SqlCommand com = new SqlCommand(UpdateQuery, dbconn.Con);
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
    
    }
}
