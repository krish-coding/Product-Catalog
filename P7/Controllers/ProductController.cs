using System;
using System.Collections.Generic;
using System.Web.Mvc;
using P7.Models;

namespace P7.Controllers
{
    public class ProductController : Controller
    {
        private static readonly List<Product> products = new List<Product>
        {
            new Product { Id = 1, Name = "Laptop", Price = 45000, Category = "Electronics", ImageUrl = "https://img.freepik.com/premium-photo/picture-laptop_931878-305748.jpg", Description = "A high-performance laptop for work and play." },
            new Product { Id = 2, Name = "Smartphone", Price = 19990, Category = "Electronics", ImageUrl = "https://imgcdn.stablediffusionweb.com/2024/10/15/2eac7182-4bef-47c2-9ea3-2d282aa1d85f.jpg", Description = "A latest model smartphone with advanced features." },
            new Product { Id = 3, Name = "Headphones", Price = 5990, Category = "Audio", ImageUrl = "https://m.media-amazon.com/images/I/51rpbVmi9XL._SL1200_.jpg", Description = "High-quality headphones for immersive audio experience." },
            new Product { Id = 4, Name = "Smartwatch", Price = 29990, Category = "Electronics", ImageUrl = "https://tse4.mm.bing.net/th/id/OIP.1k8bonqcSymPtnqLxOfc7wHaIb?r=0&rs=1&pid=ImgDetMain&o=7&rm=3", Description = "A stylish smartwatch with health monitoring features." }
        };

        public ActionResult Index()
        {
            return View(products);
        }

        public ActionResult Details(int id)
        {
            var product = products.Find(p => p.Id == id);
            if (product == null)
            {
                return HttpNotFound();
            }

            return View(product);
        }
    }
}
