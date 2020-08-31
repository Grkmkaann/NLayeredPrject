using Business.Abstract;
using DataAccess.Abstract.DataAccessObjects;
using DataAccess.Concrete.ORMs.EntityFramework.DataAccessLayers;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class WorkerManager : IWorkerService
    {

        private IWorkerDal _workerDal;
        public WorkerManager()
        {
            _workerDal = new EfWorkerDal();
        }

        public bool Add(Worker worker)
        {
            _workerDal.Add(worker);
            return true;
        }

        public List<Worker> GetAll()
        {
            return _workerDal.GetAll();
           
        }
    }
}
