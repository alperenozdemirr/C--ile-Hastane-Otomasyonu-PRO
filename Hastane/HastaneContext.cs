using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hastane
{
    public class HastaneContext:DbContext
    {
        public DbSet<PatientSignup> PatientSignups { get; set; }
        public DbSet<Staff> Staffs { get; set; }
        public DbSet<TakeQueue> TakeQueues { get; set; }
    }
}
