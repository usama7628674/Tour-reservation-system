using Tour_Reservation_System.DL;
using Tour_Reservation_System.DTO;
using Tour_Reservation_System.GUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tour_Reservation_System.BL
{
    class LoginBL
    {

        LoginDL lgDL;
        public LoginBL()
        {
            lgDL = new LoginDL();
        }

        public Form VerifyUser(LoginDTO lg)
        {
            // Here we call loginDL objects method verifyUserFromDB
            string res = lgDL.VerifyUsersFromDB(lg);
            if (res == "admin")
            {
                return new AdminMainGUI();
            }
            else if (res == "manager")
            {
                return new ManagerMainGUI();
            }

            else
            {
                //return new WrongUserGUI();
            }
            //return new WrongUserGUI();

            // Change ReturnType Also
            return new WrongUserGUI();
        }
    }
}
