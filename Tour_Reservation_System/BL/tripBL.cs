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
    class tripBL
    {
         tripDL busDL;
         public tripBL()
        {
            busDL = new tripDL();
        }
        
        public int AddNewBus(tripDTO busDTO)
        {
            int count = busDL.InsertBusInDB(busDTO);
            return count;
        }
        public DataSet FetchAll()
        {
            return busDL.FetchAllFromDB();
        }
    }
}
