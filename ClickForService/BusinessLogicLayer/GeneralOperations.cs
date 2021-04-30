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


    }
}
