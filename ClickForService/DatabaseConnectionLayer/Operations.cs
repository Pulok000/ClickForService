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
        
    }

}
