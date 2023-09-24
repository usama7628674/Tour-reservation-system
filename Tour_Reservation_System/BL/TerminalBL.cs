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
    class TerminalBL
    {
        TerminalDL terminalDL;
        public TerminalBL()
        {
            terminalDL = new TerminalDL();
        }
        
        public int AddNewTerminal(TerminalDTO terminalDTO)
        {
            int count = terminalDL.InsertTerminalInDB(terminalDTO);
            return count;
        }
        public DataSet FetchAll()
        {
            return terminalDL.FetchAllFromDB();
        }
    } 
}
