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

        public List<AccessPropertySP> GetAllComputerServices()
        {
            return this.operation.GetAllComputerServices();
        }

        public List<AccessPropertySP> GetAllMobileServices()
        {
            return this.operation.GetAllMobileServices();
        }

        //
        public int AddServiceProviderDetails(string username, double serviceCharge, string availableTime)
        {

            AccessPropertySP accessProperty = new AccessPropertySP()
            {
                UserName = username,
                ServiceCharge = serviceCharge,
                AvailStime = availableTime
            };
            this.operation = new Operations();
            return this.operation.AddServiceProviderDetails(accessProperty);
        }
        //

        public AccessPropertySP GetServiceProviderRegDetails(string userName)
        {
            return this.operation.GetServiceProviderRegDetails(userName);
        }




        public AccessPropertySP GetServiceProviderAdditionalDetails(string userName)
        {
            return this.operation.GetServiceProviderAdditionalDetails(userName);
        }



    }
}
