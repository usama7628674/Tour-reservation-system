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
    public partial class WrongUserGUI : Form
    {
        public WrongUserGUI()
        {
            InitializeComponent();
        }

        private void WrongUserGUI_FormClosing(object sender, FormClosingEventArgs e)
        {
            Login lgGui = new Login();
            this.Hide();
            lgGui.ShowDialog();
            this.Close();
        }

 
    }
}
