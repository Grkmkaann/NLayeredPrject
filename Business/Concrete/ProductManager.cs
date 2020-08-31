using Business.Abstract;
using DataAccess.Abstract;
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
    public class ProductManager:IProductService
    {

        private IProductDal _productDal;

        public ProductManager()
        {
            _productDal = new EfProductDal(); 
        }

        public List<Product> GetAll()
        {
            return _productDal.GetAll();

        }
    }
}
