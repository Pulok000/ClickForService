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


        public List<AccessProperty> GetAllComputerServices()
        {
            string s1 = "Servicer Giver";
            string s2 = "Computer or Laptop Mechanic";
            string sql = "SELECT *FROM Registrations Where category='" + s1 + "' And Profession='" + s2 + "'";
            SqlDataReader reader = this.GetData(sql);
            List<AccessProperty> Ap1 = new List<AccessProperty>();
            while (reader.Read())
            {
                AccessProperty ap = new AccessProperty();
                ap.FullName = Convert.ToString(reader["fullName"]);
                ap.Profession = Convert.ToString(reader["Profession"]);
                ap.City = Convert.ToString(reader["City"]);
                ap.Address = Convert.ToString(reader["Address"]);
                Ap1.Add(ap);
            }
            return Ap1;
        }


        public List<AccessProperty> GetAllMobileServices()
        {
            string s1 = "Servicer Giver";
            string s2 = "Mobile Mechanic";
            string sql = "SELECT *FROM Registrations Where category='" + s1 + "' And Profession='" + s2 + "'";
            SqlDataReader reader = this.GetData(sql);
            List<AccessProperty> Ap1 = new List<AccessProperty>();
            while (reader.Read())
            {
                AccessProperty ap = new AccessProperty();
                ap.FullName = Convert.ToString(reader["fullName"]);
                ap.Profession = Convert.ToString(reader["Profession"]);
                ap.City = Convert.ToString(reader["City"]);
                ap.Address = Convert.ToString(reader["Address"]);
                Ap1.Add(ap);
            }
            return Ap1;
        }
        
    }

}
