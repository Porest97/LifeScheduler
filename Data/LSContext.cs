using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LifeScheduler.Data
{
    public class LSContext : IdentityDbContext
    {
        public LSContext(DbContextOptions<LSContext> options)
            : base(options)
        {
        }
    }
}
