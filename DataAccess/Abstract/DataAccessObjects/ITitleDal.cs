﻿using DataAccess.Abstract.Repositories;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract.DataAccessObjects
{
    public interface ITitleDal: IEntityRepository<Title>
    {
    }
}
