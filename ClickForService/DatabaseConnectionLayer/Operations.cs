using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using ClickForService.DatabaseConnectionLayer;
using ClickForService.PresentationLayer;

namespace ClickForService.DatabaseConnectionLayer
{
    class Operations : DataAcess
    {
        public List<AccessProperty> GetMaid()
        {
            string sql = "SELECT *FROM Registrations";
            SqlDataReader reader = this.GetData(sql);
            List<AccessProperty> Ap1 = new List<AccessProperty>();
            while (reader.Read())
            {
                AccessProperty ap = new AccessProperty();
                ap.FullName = Convert.ToString(reader["fullName"]);
                Ap1.Add(ap);
            }
            return Ap1;
        }
        /*
        public AccessProperty Getmaid()
        {
            string sql = "SELECT *FROM Registrations WHERE userName='" + Login.UserName + "'";
            AccessProperty ap = new AccessProperty();
            SqlDataReader reader = this.GetData(sql);
            while (reader.Read())
            {

                ap.City = Convert.ToString(reader["City"]);

                string sql1 = "SELECT*FROM Registrations WHERE City='" + ap.City + "'";
                SqlDataReader read = this.GetData(sql1);
                while (read.Read())
                {
                    AccessProperty ap1 = new AccessProperty();
                    ap.FullName = Convert.ToString(reader["City"]);
                    ap.MobileNumber = Convert.ToString(reader["mobileNumber"]);

                }


            }
            return ap;

        } */
    }

}
