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
                ap.UserName = Convert.ToString(reader["userName"]);
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
                ap.UserName = Convert.ToString(reader["userName"]);
                ap.Profession = Convert.ToString(reader["Profession"]);
                ap.City = Convert.ToString(reader["City"]);
                ap.Address = Convert.ToString(reader["Address"]);
                Ap1.Add(ap);
            }
            return Ap1;
        }


        //For dashboardForservice provider:

        public int AddServiceProviderDetails(AccessProperty accessProperty)
        {

            string sql = "INSERT INTO SPTables(userName,serviceCharge,AvailStime) VALUES('" + accessProperty.UserName + "'," + accessProperty.ServiceCharge + ",'" + accessProperty.AvailStime + "')";

            return this.ExecuteNonQuery(sql);
        }

        //

        public AccessProperty GetServiceProviderRegDetails(string userName)
        {
            string s = userName;
            string sql = "SELECT * FROM Registrations Where userName='" + s + "'";
            SqlDataReader reader = this.GetData(sql);
            if (reader.Read())
            {


                AccessProperty accessProperty = new AccessProperty();
                accessProperty.UserName = reader["userName"].ToString();
                accessProperty.EmailId = reader["emailId"].ToString();
                accessProperty.Password = reader["password"].ToString();
                accessProperty.Category = reader["category"].ToString();
                accessProperty.Address = reader["Address"].ToString();
                accessProperty.City = reader["City"].ToString();
                accessProperty.Division = reader["Division"].ToString();
                accessProperty.BloodGroup = reader["bloodGroup"].ToString();
                accessProperty.MobileNumber = reader["mobileNumber"].ToString();
                accessProperty.FullName = reader["fullName"].ToString();
                accessProperty.NID = reader["NID"].ToString();
                accessProperty.DOB = reader["dateofbirth"].ToString();
                accessProperty.Gender = reader["gender"].ToString();
                accessProperty.Profession = reader["Profession"].ToString();


                return accessProperty;
            }
            return null;
        }

        //GetServiceProviderAdditionalDetails

        public AccessProperty GetServiceProviderAdditionalDetails(string userName)
        {
            string s = userName;
            string sql = "SELECT * FROM SPTables Where userName='" + s + "'";
            SqlDataReader reader = this.GetData(sql);
            if (reader.Read())
            {

                AccessProperty accessProperty = new AccessProperty();
                accessProperty.Id = Convert.ToInt32(reader["Id"].ToString());
                accessProperty.UserName = reader["userName"].ToString();
                accessProperty.ServiceCharge = Convert.ToDouble(reader["serviceCharge"]);

                try
                {
                    accessProperty.Rating = Convert.ToInt32(reader["Rating"]);
                }
                catch (Exception exp)
                {

                }

                accessProperty.AvailStime = reader["AvailStime"].ToString();

                return accessProperty;
            }
            return null;
        }

    }

}
