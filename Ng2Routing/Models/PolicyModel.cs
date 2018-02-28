using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ng2Routing.Models
{
    public class PolicyModel
    {
        public string PolicyNumber { get; set; }

        public decimal Balance { get; set; }

        public decimal AmountDue { get; set; }

        public DateTime DueDate { get; set; }
    }
}