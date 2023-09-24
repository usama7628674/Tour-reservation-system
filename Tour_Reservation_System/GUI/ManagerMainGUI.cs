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
    public partial class ManagerMainGUI : Form
    {
        public ManagerMainGUI()
        {
            InitializeComponent();
        }

        private void ManagerMainGUI_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                if (MessageBox.Show("Are you sure you want to close!!!", "Form is going to close", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }

            }
            else
            {

            }
        }

        private void btn_book_Click(object sender, EventArgs e)
        {
            Book b = new Book();
            b.ShowDialog();
        }

        private void btn_cancellation_Click(object sender, EventArgs e)
        {
            Cancellation c = new Cancellation();
            c.ShowDialog();
        }

        private void btn_bus_timmings_Click(object sender, EventArgs e)
        {
            //BusTimings bt = new BusTimings();
            //bt.ShowDialog();
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login l = new Login();
            l.Show();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
