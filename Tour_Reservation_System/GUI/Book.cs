using Tour_Reservation_System.BL;
using Tour_Reservation_System.DTO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tour_Reservation_System.GUI
{
    public partial class Book : Form
    {
        int fare;
        tourDTO routeDTO;
        tourBL routeBL;

        ReservationDTO reservationDTO;
        ReservationBL resBL;

        public Book()
        {
            InitializeComponent();
            routeBL = new tourBL();
            routeDTO = new tourDTO();
            reservationDTO = new ReservationDTO();
            resBL = new ReservationBL();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Book_Load(object sender, EventArgs e)
        {
            try
            {               
                ArrayList terminals = routeBL.FetchAllTerminalsInComboBox();
                foreach (var item in terminals)
                {
                    comboBox_from_terminal.Items.Add(item);
                    comboBox_to_terminal.Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Message is:    " + ex.Message, "Error Exeption Raised", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_search_route_Click(object sender, EventArgs e)
        {
            routeDTO.FromTerminal = comboBox_from_terminal.Text;
            routeDTO.ToTerminal = comboBox_to_terminal.Text;
            routeDTO.TravelDate = dateTimePicker.Text.ToString();
            routeDTO.BusClass = combo_bus_class.Text;

            try
            {
                DataSet dataSet = routeBL.fetchSelectedRoutesforBooking(routeDTO);
                DataGridViewDetails.DataSource = dataSet.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Message is:    " + ex.Message, "Error Exeption Raised", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DataGridViewDetails_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                
                try
                {
                    DataGridViewRow row = DataGridViewDetails.Rows[e.RowIndex];
                    if (Convert.ToInt64(row.Cells[3].Value) == 0)
                    {
                        MessageBox.Show("Message is:    \n\nBus Capacity is Full\n\nSelect Another Bus" , "Error Exeption Raised", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        tb_bus_number.Text = row.Cells[1].Value.ToString();
                        tb_available_seats.Text = row.Cells[3].Value.ToString();
                        fare = Convert.ToInt32(row.Cells[8].Value);
                    }
                   
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Message is:    " + ex.Message, "Error Exeption Raised", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {           
            try
            {
                if (comboBox_from_terminal.Text != "" && comboBox_to_terminal.Text != "" && combo_bus_class.Text != "" && tb_bus_number.Text != "" && tb_name.Text != "" && tb_cnic.Text != "" && tb_seatsQuantity_forBooking.Text != "" && tb_phone.Text != "")
                {
                    reservationDTO.FromTerminal = comboBox_from_terminal.Text;
                    reservationDTO.ToTerminal = comboBox_to_terminal.Text;
                    reservationDTO.TravelDate = dateTimePicker.Text.ToString();
                    reservationDTO.BusClass = combo_bus_class.Text;
                    reservationDTO.BusNumber = tb_bus_number.Text;
                    reservationDTO.CustomerName = tb_name.Text;
                    reservationDTO.CNIC = tb_cnic.Text;
                    reservationDTO.SeatsQuantity = tb_seatsQuantity_forBooking.Text;
                    reservationDTO.PhoneNumber = tb_phone.Text;
                    int farecal = fare * Convert.ToInt32(tb_seatsQuantity_forBooking.Text);
                    reservationDTO.Fare = farecal.ToString();
                    reservationDTO.Status = "Reserved";

                    routeDTO.BusNumber = tb_bus_number.Text;
                    routeDTO.FromTerminal = comboBox_from_terminal.Text;
                    routeDTO.ToTerminal = comboBox_to_terminal.Text;
                    routeDTO.BusSeater = tb_seatsQuantity_forBooking.Text;



                    // Adding New Reservation
                    int count = resBL.AddNewReservation(reservationDTO);
                    int count2 = routeBL.UpdateQuanityInRoutes(routeDTO);

                    if (count == 1 && count2 == 1)
                    {
                        MessageBox.Show("01 Data Processed Successfully. ", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        
                        tb_bus_number.Text = "" ;
                        tb_name.Text = "" ;
                        tb_cnic.Text = "" ; 
                        tb_seatsQuantity_forBooking.Text = "" ;
                        tb_phone.Text = "";
                    }
                    else
                    {
                        MessageBox.Show(" 02 Error!!!! Data is not Proccessed ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                else
                {
                    MessageBox.Show("Please Fill All Feilds First. ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(" 03 Message is:    " + ex.Message, "Error Exeption Raised", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
