using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Data.Entity;

namespace mvcGITBranchWalkthru.Models
{
    public class GitContext : DbContext
    {
        public DbSet<GitAccount>GitAccounts { get; set; }
    }
}