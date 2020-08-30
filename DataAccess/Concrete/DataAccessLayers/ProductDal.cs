using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DataAccess.Concrete
{
    public class ProductDal
    {

        private List<Product> products = new List<Product>();

        public List<Product> GetAll()
        {

            return products;

        }
        public List<Product> Get(int id)
        {
            return products;

        }


        public List<Product> Add(Product product)
        {
            return products;

        }

        public List<Product> Update(Product product)
        {
            return products;

        }
        public List<Product> Delete(Product product)
        {
            return products;

        }



    }
}
