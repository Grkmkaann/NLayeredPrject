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
    public class DepartmantManager : IDepartmantService
    {
        private IDepartmantDal _departmantDal;
        public DepartmantManager()
        {
            _departmantDal = new EfDepartmantDal();
        }
        public List<Departmant> GetAll()
        {
           return _departmantDal.GetAll();
        }
    }
}
