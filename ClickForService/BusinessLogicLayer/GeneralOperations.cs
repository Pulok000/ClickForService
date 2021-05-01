using ClickForService.DatabaseConnectionLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClickForService.BusinessLogicLayer
{
    class GeneralOperations
    {
        Operations operation;
        public GeneralOperations()
        {
            this.operation = new Operations();
        }

        public List<AccessProperty> GetMaid()
        {
            return this.operation.GetMaid();
        }

        public List<AccessProperty> GetAllComputerServices()
        {
            return this.operation.GetAllComputerServices();
        }

        public List<AccessProperty> GetAllMobileServices()
        {
            return this.operation.GetAllMobileServices();
        }

        //
        public int AddServiceProviderDetails(string username, double serviceCharge, string availableTime)
        {

            AccessProperty accessProperty = new AccessProperty()
            {
                UserName = username,
                ServiceCharge = serviceCharge,
                AvailStime = availableTime
            };
            this.operation = new Operations();
            return this.operation.AddServiceProviderDetails(accessProperty);
        }
        //

        public AccessProperty GetServiceProviderRegDetails(string userName)
        {
            return this.operation.GetServiceProviderRegDetails(userName);
        }




        public AccessProperty GetServiceProviderAdditionalDetails(string userName)
        {
            return this.operation.GetServiceProviderAdditionalDetails(userName);
        }



    }
}
