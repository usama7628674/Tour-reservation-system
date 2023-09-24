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
    public partial class AdminMainGUI : Form
    {
        public AdminMainGUI()
        {
            InitializeComponent();
        }

        private void AdminMainGUI_FormClosing(object sender, FormClosingEventArgs e)
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

        private void btn_bus_Click(object sender, EventArgs e)
        {
            Addtrip bt = new Addtrip();
            bt.ShowDialog();

        }

        private void btn_terminal_Click(object sender, EventArgs e)
        {
            AddTerminal bt = new AddTerminal();
            bt.ShowDialog();
        }

        private void btn_manage_routes_Click(object sender, EventArgs e)
        {
            tours r = new tours();
            r.ShowDialog();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login l = new Login();
            l.Show();
        }
    }
}
