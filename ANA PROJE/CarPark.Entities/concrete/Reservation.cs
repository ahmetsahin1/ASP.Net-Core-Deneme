using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarPark.Entities.concrete
{
    public class Reservation
    {
        [BsonId]
        public ObjectId Id { get; set; }
        public string ImagePath { get; set; }
        public string Plate { get; set; } //plaka
        public DateTime BeginDate { get; set; } //otoparkta kaldıgı süreyi hesaplamak için bu giris saati
        public DateTime? EndDate { get; set; } //otoparkta kaldıgı süreyi hesaplamak için bu cikis saati
        public bool IsExit { get; set; } //ciktimi
        public bool IsPayment { get; set; } //odemeyi yaptimi
        public ReservationDetail ReservationDetail { get; set; }


    }
}
