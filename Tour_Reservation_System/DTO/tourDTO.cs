using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tour_Reservation_System.DTO
{
    class tourDTO
    {

        public tourDTO()
        { }

        private String _busNumber;
        private String _busClass;
        private String _busSeater;
        private String _travelDate;
        private String _fromTerminal;
        private String _toTerminal;
        private String _departureTime;
        private String _fare;

         
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
        public String TravelDate
        {
            get { return _travelDate; }
            set { _travelDate = value; }
        }
        public String FromTerminal
        {
            get { return _fromTerminal; }
            set { _fromTerminal = value; }
        }
        public String ToTerminal
        {
            get { return _toTerminal; }
            set { _toTerminal = value; }
        }
        public String DepartureTime
        {
            get { return _departureTime; }
            set { _departureTime = value; }
        } 
        public String Fare
        {
            get { return _fare; }
            set { _fare = value; }
        }
    }
}
