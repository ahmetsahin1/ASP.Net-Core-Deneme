using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarPark.Entities.concrete
{
    public class FloorInformation
    {
        [BsonId]
        public ObjectId Id { get; set; }
        public int Number { get; set; }
        public ICollection<SlotInformation> Slots { get; set; }

    }
}
