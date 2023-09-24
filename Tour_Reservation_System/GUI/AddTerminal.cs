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
    public partial class AddTerminal : Form
    {
        TerminalDTO terminalDTO;
        TerminalBL terminalBL;

        public AddTerminal()
        {
            InitializeComponent();
            terminalDTO = new TerminalDTO();
            terminalBL = new TerminalBL();
        }

        private void AddTerminal_Load(object sender, EventArgs e)
        {
            try
            {
                DataSet dataSet = terminalBL.FetchAll();
                DataGridViewDetails.DataSource = dataSet.Tables[0];

            }
            catch (Exception ex)
            {
                MessageBox.Show("Message is:    " + ex.Message, "Error Exeption Raised", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_add_terminal_Click(object sender, EventArgs e)
        {
            try
            {


                if (tb_terminal_city.Text != "")
                {
                    terminalDTO.TerminalCity = tb_terminal_city.Text;


                    // Adding New Terminal
                    int count = terminalBL.AddNewTerminal(terminalDTO);

                    if (count == 1)
                    {
                        MessageBox.Show("Data Processed Successfully. ", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        AddTerminal_Load(sender, e);
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

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
