using Tour_Reservation_System.BL;
using Tour_Reservation_System.DTO;
using System;
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
    public partial class Addtrip : Form
    {
        

        tripDTO busDTO;
        tripBL busBL;
        public Addtrip()
        {
            InitializeComponent();
           
            busBL = new tripBL();
            busDTO = new tripDTO();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

        private void btn_add_bus_Click(object sender, EventArgs e)
        {
            try
            {


                if (tb_bus_number.Text != "" && tb_bus_seater.Text != "" && combo_bus_class.Text != "")
                {
                    
                    busDTO.BusNumber = tb_bus_number.Text;
                    busDTO.BusSeater = tb_bus_seater.Text;
                    busDTO.BusClass = combo_bus_class.Text;


                    // Adding New Bus
                    int count = busBL.AddNewBus(busDTO);

                    if (count == 1)
                    {
                        MessageBox.Show("Data Processed Successfully. ", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        tb_bus_number.Text = "";
                        tb_bus_seater.Text = "";
                        tb_bus_driver.Text = "";
                        combo_bus_class.SelectedIndex = -1;
                        AddBus_Load(sender, e);
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

        private void AddBus_Load(object sender, EventArgs e)
        {
            try
            {
                DataSet dataSet = busBL.FetchAll();
                DataGridViewDetails.DataSource = dataSet.Tables[0];

            }
            catch (Exception ex)
            {
                MessageBox.Show("Message is:    " + ex.Message, "Error Exeption Raised", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
