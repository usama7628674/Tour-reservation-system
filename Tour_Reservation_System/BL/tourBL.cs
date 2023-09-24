using Tour_Reservation_System.DL;
using Tour_Reservation_System.DTO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tour_Reservation_System.BL
{
    class tourBL
    {

        tourDL routeDL;
         public tourBL()
        {
            routeDL = new tourDL();
        }

         public int AddNewRoute(tourDTO routeDTO)
        {
            int count = routeDL.InsertRouteInDB(routeDTO);
            return count;
        }
         public DataSet FetchAll()
         {
             return routeDL.FetchAllFromDB();
         }

         public DataSet fetchSelectedRoutes(tourDTO routeDTO) 
         {
             return routeDL.fetchSelectedRoutesFromDB(routeDTO);
         }
         public DataSet fetchSelectedRoutesforBooking(tourDTO routeDTO)
         {
             return routeDL.fetchSelectedRoutesforBookingfromDB(routeDTO);
         }
       
         public ArrayList FetchAllBusesNamesInComboBox()
         {
             return routeDL.FetchAllBusesNames();
         }

         public ArrayList FetchAllTerminalsInComboBox()
         {
             return routeDL.FetchAllTerminalsNames();
         }
         public int UpdateQuanityInRoutes(tourDTO routeDTO)
         {
             int count = routeDL.UpdateSeatsQuantityInDB(routeDTO);
             return count;
         }
    }
}
