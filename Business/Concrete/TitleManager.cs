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
    public class TitleManager : ITitleService
    {
        private ITitleDal _titleDal;
        public TitleManager()
        {
            _titleDal = new EfTitleDal();
        }
        public List<Title> GetAll()
        {
          return  _titleDal.GetAll();
        }
    }
}
