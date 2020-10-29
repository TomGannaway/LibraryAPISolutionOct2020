using LibraryAPI.Models.Status;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryAPI.Services
{
    public class HealthMonitoringApiServerStatus : IProvideServerStatusInformation
    {
        public GetStatusResponse GetCurrentStatus()
        {
            // do what you need to call the external service...
            // we'll fake it
            return new GetStatusResponse
            {
                Message = "All is good!",
                CreatedAt = DateTime.Now
            };
        }
    }
}
