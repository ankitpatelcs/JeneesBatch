
using System.Data.Entity;
using codeFirst.Models;

namespace codeFirst.Models
{
    public partial class CompanyEntities : DbContext
    {
        public CompanyEntities() : base("name=CompanyEntities")
        {
        }

        public virtual DbSet<tblcity> tblcities { get; set; }
        public virtual DbSet<tblemployee> tblemployees { get; set; }
        public virtual DbSet<tblstate> tblstates { get; set; }

    }
}
