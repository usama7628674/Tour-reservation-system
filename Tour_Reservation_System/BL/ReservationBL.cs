using Tour_Reservation_System.DL;
using Tour_Reservation_System.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tour_Reservation_System.BL
{
    class ReservationBL
    {
        ReservationDL resDL;
         public ReservationBL()
        {
            resDL = new ReservationDL();
        }
        
        public int AddNewReservation(ReservationDTO resDTO)
        {
            int count = resDL.InsertReservationInDB(resDTO);
            return count;
        }
        public DataSet cancelReservation(ReservationDTO resDTO)
        {
            return resDL.cancelReservationFromDB(resDTO);
        }
        public int UpdateCancel(ReservationDTO resDTO)
        {
            int count = resDL.UpdateCancelInDB(resDTO);
            return count;
        }
    }
}
 