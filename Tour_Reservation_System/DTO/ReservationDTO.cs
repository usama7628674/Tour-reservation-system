using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tour_Reservation_System.DTO
{
    class ReservationDTO
    {

        public ReservationDTO()
        { }

        private String _customerName;
        private String _phoneNumber;
        private String _cNIC;
        private String _seatsQuantity;
        private String _totalSeats;
        private String _fromTerminal;
        private String _toTerminal;
        private String _travelDate;
        private String _status;
        private String _fare;
        private String _busNumber;
        private String _busClass;
        private int _ticketID;

        public int TicketID
        {
            get { return _ticketID; }
            set { _ticketID = value; }
        } 

        public String BusClass
        {
            get { return _busClass; }
            set { _busClass = value; }
        }

        public String BusNumber
        {
            get { return _busNumber; }
            set { _busNumber = value; }
        }
        

        public String PhoneNumber
        {
            get { return _phoneNumber; }
            set { _phoneNumber = value; }
        }
        

        public String CNIC
        {
            get { return _cNIC; }
            set { _cNIC = value; }
        }
        

        public String SeatsQuantity
        {
            get { return _seatsQuantity; }
            set { _seatsQuantity = value; }
        }
        
         
        public String TotalSeats
        {
            get { return _totalSeats; }
            set { _totalSeats = value; }
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
        

        public String TravelDate
        {
            get { return _travelDate; }
            set { _travelDate = value; }
        }
        

        public String Fare
        {
            get { return _fare; }
            set { _fare = value; }
        }
        

        public String Status
        {
            get { return _status; }
            set { _status = value; }
        }



        public String CustomerName
        {
            get { return _customerName; }
            set { _customerName = value; }
        }
    
         
    }
}
