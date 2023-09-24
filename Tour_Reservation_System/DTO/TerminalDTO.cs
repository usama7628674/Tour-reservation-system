using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tour_Reservation_System.DTO
{
    class TerminalDTO
    {
        public TerminalDTO()
        { }

        private String _terminalCity;

        public String TerminalCity
        {
            get { return _terminalCity; }
            set { _terminalCity = value; }
        }

    }
}
