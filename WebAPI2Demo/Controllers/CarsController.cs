using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPI2Demo.Models;

namespace WebAPI2Demo.Controllers
{
    //Tämän kontrollin tehtävänä on palauttaa metodin avulla
    //kaikki autot  metodilla GetAllCars
    //yksittäinen auto id:n perusteella metodilla GetCar
    public class CarsController : ApiController
    {
        //luodaan testausta varten lista autoja
        Car[] cars = new Car[]
        {
        new Car {Id=1, Name="Audi", Model="A4", Price=24000, Url="http://buyersguide.caranddriver.com/media/assets/submodel/7085.jpg"},
        new Car {Id=2, Name="Audi", Model="A6", Price=29000, Url="http://www.autowiki.fi/images/3/30/Audi_A6_2.0_TDI_%28C7%29_%E2%80%93_Frontansicht.jpg"},
        new Car {Id=3, Name="BMW", Model="320", Price=22000, Url="http://thebestautos.net/wp-content/uploads/2016/05/Salon-BMW-320d.jpg"},
        new Car {Id=4, Name="Volvo", Model="V70", Price=47000, Url="http://bestsellingcarsblog.com/2012/01/02/sweden-full-year-2011-volvo-v70-leads-for-16th-consecutive-year/volvo-v70-sweden-december-2011/"}
        };
        public IEnumerable<Car> GetAllCars()
        {
            return cars;
        }

        public IHttpActionResult GetCar(int id)
        {
            var car = cars.FirstOrDefault((p) => p.Id == id);
            if (car == null)
            {
                return NotFound();
            }
            return Ok(car);
        }
    }
   
}
