using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BusTravelsManagement.Models
{
    public class Repository
    {
        public List<BusInfo> GetBusInfos()
        {
            BusTravelsManagementDB dbContext = new BusTravelsManagementDB();
            return dbContext.BusInfoes.ToList();
        }
    }
}