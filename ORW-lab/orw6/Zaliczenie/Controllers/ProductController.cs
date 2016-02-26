using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Zaliczenie.Models;

namespace Zaliczenie.Controllers
{
    public class ProductController : ApiController
    {
        private List<Product> products = new List<Product>() 
        { 
            new Product{Id=1,Name="Diablo 3",Price=60,Qty=6},
            new Product{Id=2,Name="StarCraft 2",Price=90,Qty=6},
            new Product{Id=3,Name="Warcraft 3",Price=90,Qty=6},
            new Product{Id=4,Name="World of Warcraft",Price=90,Qty=6},
            new Product{Id=5,Name="Hearthstone",Price=90,Qty=6},
            new Product{Id=6,Name="Heroes of the Storm",Price=90,Qty=6}
        };
        public IEnumerable<Product> Get()
        {
            return products.ToList();
        }
        public IHttpActionResult Get(int id)
        {
            var product = products.Where(x => x.Id == id);
            if (product == null)
                return NotFound();
            return Ok(product);
        }
    }
}
