using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IWorkerService
    {

        List<Worker> GetAll();
        bool Add(Worker worker);

    }
}
