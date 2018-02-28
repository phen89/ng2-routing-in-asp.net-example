using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using Ng2Routing.Models;

namespace Ng2Routing.Controllers.Api
{
    public class PolicyController : ApiController
    {
        public Task<PolicyModel> Get()
        {
            return Task.FromResult(new PolicyModel
            {
                AmountDue = 12,
                Balance = 23,
                DueDate = DateTime.Today.AddDays(1),
                PolicyNumber = "STUB-1234"
            });
        }
    }
}
