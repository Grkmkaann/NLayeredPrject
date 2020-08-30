using DataAccess.Abstract;
using DataAccess.Concrete.ORMs.EntityFramework.DBContexts;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DataAccess.Concrete.ORMs.EntityFramework.DataAccessLayers
{
    public class EfProductDal:IProductDal
    {

        //private List<Product> _products;

        public EfProductDal()
        {
           //_products = new List<Product>();
        }

        public List<Product> GetAll()
        {

            using (NorthwindContext context = new NorthwindContext())
            {
                    return context.Products.ToList();
            }



        }
        public List<Product> Get(int productId)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                return context.Products.Where(p=>p.ProductId==productId).ToList();

            }


        }

        public void Add(Product product)
        {
   
        }
        public void Update(Product product)
        {
          

        }
        public void Delete(Product product)
        {
         

        }

      
    }
}
