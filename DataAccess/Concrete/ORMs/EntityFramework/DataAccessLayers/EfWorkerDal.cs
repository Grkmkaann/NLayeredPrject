using DataAccess.Abstract.DataAccessObjects;
using DataAccess.Concrete.ORMs.EntityFramework.Base;
using DataAccess.Concrete.ORMs.EntityFramework.DBContexts;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.ORMs.EntityFramework.DataAccessLayers
{
    public class EfWorkerDal : EfEntityRepositoryBase<Worker, BusinessDBContext>, IWorkerDal
    {
    }
}
