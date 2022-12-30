using CarPark.Core.Repository.Abstract;
using CarPark.Entities.concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarPark.DataAccess.Abstract
{
    public interface ICityDataAccess : IRepository<City>
    {
    }
}
