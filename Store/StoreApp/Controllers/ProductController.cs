using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Repositories;
using Entities.Models;



namespace StoreApp.Controllers
{
    // [ApiController]
    // [Route("api/[controller]")] // api/product ne işe yarar : api/product ile başlayan istekler bu controller'a yönlendirilir.
    public class ProductController : Controller
    {
        private readonly RepositoryContext _context;
        //*************************************************************
        // Dependency injection
        public ProductController(RepositoryContext context)
        {
            _context = context;
        }

        // alternative
        // public IEnumerable<Product> Index()
        // {
        //     // var context = new RepositoryContext(
        //     //     new DbContextOptionsBuilder<RepositoryContext>()
        //     //     .UseSqlite("Data Source = C:\\sqlite3\\ProductDb.db")
        //     //     .Options);

        //     return _context.Products;
        // }



        public IActionResult Index()
        {
            var model = _context.Products.ToList();
            return View(model);
        }


        public IActionResult Get(int id)
        {
            Product product = _context.Products.First(p => p.ProductId.Equals(id));
            return View(product);
        }



    }
}