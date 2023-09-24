using Tour_Reservation_System.DTO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tour_Reservation_System.DL
{
    class tourDL
    {
         DBConnection dbconn;

         public tourDL()
        {
            dbconn = new DBConnection();
        }

         public int InsertRouteInDB(tourDTO routeDTO)
        {
            try
            {
                dbconn.Con.Open();

                String insertDonorQuery = "insert into tour (trip_name, trip_class, trip_people_capacity , travel_date, from_terminal, to_terminal, departure_time, fare) values (@BusNumber, @BusClass, @BusSeater, @TravelDate, @FromTerminal, @ToTerminal, @DepartureTime, @Fare)";
                SqlCommand com = new SqlCommand(insertDonorQuery, dbconn.Con);

                com.Parameters.AddWithValue("@BusNumber", routeDTO.BusNumber);
                com.Parameters.AddWithValue("@BusSeater", routeDTO.BusSeater);
                com.Parameters.AddWithValue("@BusClass", routeDTO.BusClass);
                com.Parameters.AddWithValue("@FromTerminal", routeDTO.FromTerminal);
                com.Parameters.AddWithValue("@ToTerminal", routeDTO.ToTerminal);
                com.Parameters.AddWithValue("@DepartureTime", routeDTO.DepartureTime);
                com.Parameters.AddWithValue("@TravelDate", routeDTO.TravelDate);
                com.Parameters.AddWithValue("@Fare", routeDTO.Fare);

               
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
                 string query = "select * from tour";
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

        
         public ArrayList FetchAllBusesNames()
         {
             try
             {
                 dbconn.Con.Open();
                 SqlCommand cmd;
                 SqlDataReader dr;
                 ArrayList names = new ArrayList();

                 cmd = new SqlCommand("select trip_name from trip", dbconn.Con);
                 dr = cmd.ExecuteReader();
                 while (dr.Read())
                 {
                     names.Add(dr[0].ToString());
                 }
                 
                 dr.Close();
                 dbconn.Con.Close();
                 return names;
             }
             catch (SqlException e)
             {
                 throw e;
             }
         }

         public ArrayList FetchAllTerminalsNames()
         {
             try
             {
                 dbconn.Con.Open();
                 SqlCommand cmd;
                 SqlDataReader dr;
                 ArrayList names = new ArrayList();

                 cmd = new SqlCommand("select terminal_city from Terminal", dbconn.Con);
                 dr = cmd.ExecuteReader();
                 while (dr.Read())
                 {
                     names.Add(dr[0].ToString());
                 }

                 dr.Close();
                 dbconn.Con.Close();
                 return names;
             }
             catch (SqlException e)
             {
                 throw e;
             }
         }

         public DataSet fetchSelectedRoutesFromDB(tourDTO routeDTO)
         {
            try
            {


                String query = "select * from tour where from_terminal = @FromTerminal AND to_terminal = @ToTerminal";
                SqlCommand cmd = new SqlCommand();
                cmd.Parameters.AddWithValue("@FromTerminal", routeDTO.FromTerminal);
                cmd.Parameters.AddWithValue("@ToTerminal", routeDTO.ToTerminal);
                
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

         public DataSet fetchSelectedRoutesforBookingfromDB(tourDTO routeDTO)
         {
             try
             {
 
                 String query = "select * from tour where from_terminal = @FromTerminal AND to_terminal = @ToTerminal AND trip_class = @BusClass AND travel_date = @TravelDate";
                 SqlCommand cmd = new SqlCommand();
                 cmd.Parameters.AddWithValue("@FromTerminal", routeDTO.FromTerminal);
                 cmd.Parameters.AddWithValue("@ToTerminal", routeDTO.ToTerminal);
                 cmd.Parameters.AddWithValue("@BusClass", routeDTO.BusClass);
                 cmd.Parameters.AddWithValue("@TravelDate", routeDTO.TravelDate);

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

         public int UpdateSeatsQuantityInDB(tourDTO routerDTO)
         {

             try
             {
                 dbconn.Con.Open();
                 String UpdateQuery = "update tour set trip_people_capacity=trip_people_capacity-" + routerDTO.BusSeater + " where from_terminal = '" + routerDTO.FromTerminal + "' AND to_terminal = '"+ routerDTO.ToTerminal + "' AND trip_name = '"+ routerDTO.BusNumber+ "'";
                 
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
