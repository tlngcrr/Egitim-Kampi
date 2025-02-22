using C301.EntityLayer.Concrete;
using CSharp301.DataAccessLayer.Abstract;
using CSharp301.DataAccessLayer.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp301.DataAccessLayer.EntityFramework
{
    //IAdminDal'dan miras almasının sebebi  
    public class EfadminDal:GenericRepository<Admin>,IAdminDal
    {
    }
}
