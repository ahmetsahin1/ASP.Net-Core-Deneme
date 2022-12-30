using CarPark.Entities.concrete;
using CarPark.User.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MongoDB.Bson;
using MongoDB.Driver;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace CarPark.User.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly MongoClient client;
        
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            //client = new MongoClient("mongodb+srv://sahinahmet:147Abc963@carparkcluster.k8dh4x2.mongodb.net/CarParkDB?retryWrites=true&w=majority");
        }

        public IActionResult Index()
        {
            //var database = client.GetDatabase("CarParkDB");
            //var jsonString = System.IO.File.ReadAllText("cities.json");
            //var cities = JsonConvert.DeserializeObject<List<cities>>(jsonString);
            //var citiesCollection = database.GetCollection<City>("City");
            //foreach(var item in cities)
            //{
            //    var city = new City() //burada jsondan çevirdiğimiz verileri mongo db ye atama işlemlerini yapıyoruz
            //    {
            //        Id = ObjectId.GenerateNewId(),
            //        Name=item.name,
            //        Plate=item.plate,
            //        Latitude=item.latitude,
            //        Logitude=item.longitude,
            //        Counties=new   List<County>()
            //    };

            //    foreach (var item2 in item.counties)
            //    {
            //        city.Counties.Add(new County
            //        {
            //            Id = ObjectId.GenerateNewId(),
            //            Name = item2,
            //            Latitude="",
            //            Longitude="",
            //            PostCode=""

            //        });

            //    }
            //    citiesCollection.InsertOne(city);
            //}
         
            return View();
        }

        public IActionResult Privacy()
        {           
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult Dashboard()
        {
            return View();
        }
    }
}
