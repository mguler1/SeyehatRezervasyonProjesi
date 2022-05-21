using DataAccess.Abstract;
using DataAccess.Repository;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Ef
{
    public class EfGuideDal: EfGenericRepository<Guide>, IGuideDal
    {
    }
}
