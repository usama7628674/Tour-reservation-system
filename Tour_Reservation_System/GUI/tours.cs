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
    public partial class tours : Form
    {
        tourDTO routeDTO;
        tourBL routeBL;
        public tours()
        {
            InitializeComponent();
            routeBL = new tourBL();
            routeDTO = new tourDTO();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_add_bus_Click(object sender, EventArgs e)
        {
            try
            {


                if (comboBox_bus_number.Text != "" && tb_seater.Text != "" && combo_bus_class.Text != "" && tb_departure_time.Text != "" && comboBox_from_terminal.Text != "" && comboBox_to_terminal.Text != "" && tb_fare.Text != "")
                {

                    routeDTO.BusNumber = comboBox_bus_number.Text;
                    routeDTO.BusSeater = tb_seater.Text;
                    routeDTO.BusClass = combo_bus_class.Text;
                    routeDTO.DepartureTime = tb_departure_time.Text;
                    routeDTO.FromTerminal = comboBox_from_terminal.Text;
                    routeDTO.ToTerminal = comboBox_to_terminal.Text;
                    routeDTO.Fare = tb_fare.Text;
                    routeDTO.TravelDate = dt_travel_date.Text.ToString();


                    // Adding New Bus
                    int count = routeBL.AddNewRoute(routeDTO);

                    if (count == 1)
                    {
                        MessageBox.Show("Data Processed Successfully. ", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        comboBox_bus_number.Text = "";
                        combo_bus_class.SelectedIndex = -1;

                        tb_seater.Text = "";
                        combo_bus_class.Text = "";
                        tb_departure_time.Text = "";
                        comboBox_from_terminal.SelectedIndex = -1;
                        comboBox_to_terminal.SelectedIndex = -1;
                        tb_fare.Text = "";
                        Routes_Load(sender, e);  // Reloading table

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

        private void Routes_Load(object sender, EventArgs e)
        {
            try
            {
                DataSet dataSet = routeBL.FetchAll();
                DataGridViewDetails.DataSource = dataSet.Tables[0];
               
                ArrayList names = routeBL.FetchAllBusesNamesInComboBox();
                foreach (var item in names)
                {
                    comboBox_bus_number.Items.Add(item);
                }

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
    }
}
