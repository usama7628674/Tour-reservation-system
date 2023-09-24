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

namespace Tour_Reservation_System
{
    public partial class Login : Form
    {
        LoginDTO loginDto;
        LoginBL lgBL;  

        public Login()
        {
            InitializeComponent();
            loginDto = new LoginDTO();
            lgBL = new LoginBL();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txt_password.Text = "";
            txt_UserName.Text = "";
            txt_UserName.Focus();
        }

        private void tn_Login_Click(object sender, EventArgs e)
        {
            if (!(txt_UserName.Text == "" || txt_password.Text == ""))
            {

                loginDto.UserName = txt_UserName.Text;
                loginDto.Password = txt_password.Text;
                this.Hide();
                lgBL.VerifyUser(loginDto).ShowDialog();
                this.Close();
                btnReset_Click(sender, e);

            }
            else
            {
                MessageBox.Show("Please Fill All Fields First....!!", "Error...!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
