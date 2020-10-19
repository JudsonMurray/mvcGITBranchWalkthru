using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace mvcGITBranchWalkthru.Models
{
    public class GitAccount
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
    }
}