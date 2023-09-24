using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tour_Reservation_System.DL
{
    class DBConnection
    {
        private SqlConnection con;

        public SqlConnection Con
        {
            get { return con; }
            set { con = value; }
        }
        public DBConnection()
        {

            string Path = Environment.CurrentDirectory;
            string[] appPath = Path.Split(new string[] { "bin" }, StringSplitOptions.None);
            AppDomain.CurrentDomain.SetData("DataDirectory", appPath[0]);
            string conString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + appPath[0] + @"Database1.mdf;Integrated Security=True"; 

            con = new SqlConnection(conString);

        }
    }
}
