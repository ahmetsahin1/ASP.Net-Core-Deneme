using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarPark.Entities.concrete
{
    public class CarPark
    {
        [BsonId]
        public ObjectId Id { get; set; }
        public string Name { get; set; }
        public string[] PhoneNumbers { get; set; }
        public Address Address { get; set; }
        public string[] Personels { get; set; }
        public string Website { get; set; }
        public string[] EmailAddresses { get; set; }
        public ICollection<WorkingDay> WorkingDays { get; set; }
        public ICollection<FloorInformation> Floors { get; set; }





    }
}
