using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarPark.Entities.concrete
{
    public class WorkingHour
    {
        public ICollection<Translation> Translations { get; set; }

    }
}
