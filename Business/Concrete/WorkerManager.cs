using Business.Abstract;
using Business.ValidationRules.FluentValidation;
using DataAccess.Abstract.DataAccessObjects;
using DataAccess.Concrete.ORMs.EntityFramework.DataAccessLayers;
using Entities.Concrete;
using FluentValidation;
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
            WorkerValidator validator = new WorkerValidator();
            var result = validator.Validate(worker);
            if (result.Errors.Count > 0)
            {
                throw new ValidationException(result.Errors);
            }
            return _workerDal.Add(worker);
        }


        public List<Worker> GetAll()
        {
            return _workerDal.GetAll();
           
        }

        public bool Update(Worker worker)
        {
            WorkerValidator validator = new WorkerValidator();
            var result = validator.Validate(worker);
            if (result.Errors.Count > 0)
            {
                throw new ValidationException(result.Errors);
            }
            return _workerDal.Update(worker);
        }


        public bool Delete(Worker worker)
        {
            return _workerDal.Delete(worker);
        }

    }
}
