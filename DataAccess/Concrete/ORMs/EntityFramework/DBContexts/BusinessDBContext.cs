using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.ORMs.EntityFramework.DBContexts
{
   public  class BusinessDBContext: DbContext
    {
        public DbSet<Worker> Workers { get; set; }
        public DbSet<Title> Titles { get; set; }
        public DbSet<Departmant> Departmants { get; set; }
    }
}
