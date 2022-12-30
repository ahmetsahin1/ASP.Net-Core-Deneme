using CarPark.Core.Settings;
using CarPark.DataAccess.Abstract;
using CarPark.DataAccess.Repository;
using CarPark.Entities.concrete;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarPark.DataAccess.Concrete
{
    public class CityDataAccess : MongoRepositoryBase<City>, ICityDataAccess
    {
        public CityDataAccess(IOptions<MongoSettings> settings) : base(settings)
        {
        }
    }
}
