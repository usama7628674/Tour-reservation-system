using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tour_Reservation_System.DTO
{
    class tripDTO
    {

        public tripDTO()
        { }

        private String _busNumber;
        private String _busClass;
        private String _busSeater;


        public String BusNumber
        {
            get { return _busNumber; }
            set { _busNumber = value; }
        }

        public String BusClass
        {
            get { return _busClass; }
            set { _busClass = value; }
        }

        public String BusSeater
        {
            get { return _busSeater; }
            set { _busSeater = value; }
        }
    }
}
