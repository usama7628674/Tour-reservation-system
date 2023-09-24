using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tour_Reservation_System.BL;
using Tour_Reservation_System.DTO;

namespace Tour_Reservation_System.GUI
{
    public partial class Cancellation : Form
    {
        ReservationDTO resDTO;
        ReservationBL resBL;
        public Cancellation()
        {
            InitializeComponent();
            resBL = new ReservationBL();
            resDTO = new ReservationDTO();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            resDTO.TicketID = Convert.ToInt32(tb_ticket_id.Text);
            resDTO.TravelDate = dt_travel_date.Text.ToString();

            try
            {
                DataSet dataSet = resBL.cancelReservation(resDTO);

                if (dataSet.Tables[0].Rows.Count == 0)
                {
                    MessageBox.Show("There is No Reservation on Selectd Date    ", "Error Exeption Raised", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    txt_ticket_id.Text = dataSet.Tables[0].Rows[0][0].ToString();
                    txt_name.Text = dataSet.Tables[0].Rows[0][1].ToString();
                    txt_phone.Text = dataSet.Tables[0].Rows[0][2].ToString();
                    txt_cnic.Text = dataSet.Tables[0].Rows[0][3].ToString();
                    txt_seat_quantity.Text = dataSet.Tables[0].Rows[0][4].ToString();
                    txt_from.Text = dataSet.Tables[0].Rows[0][5].ToString();
                    txt_to.Text = dataSet.Tables[0].Rows[0][6].ToString();
                    txt_fare.Text = dataSet.Tables[0].Rows[0][8].ToString();
                    txt_ticket_status.Text = dataSet.Tables[0].Rows[0][9].ToString();
                }


                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Message is:    " + ex.Message, "Error Exeption Raised", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
           
            try
            {
                resDTO.Status = "Canceled";
                resDTO.TicketID = Convert.ToInt32(txt_ticket_id.Text);

               int count = resBL.UpdateCancel(resDTO);
                if (count == 1)
                {
                    MessageBox.Show("Reservation Canceled Successfully. ", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);                 
                }
                else
                {
                    MessageBox.Show(" 02 Error!!!! Data is not Proccessed ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Message is:    " + ex.Message, "Error Exeption Raised", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
