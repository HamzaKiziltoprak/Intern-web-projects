using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using BtkAkademi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace BtkAkademi.Controllers
{

    public class CourseController : Controller
    {
       public IActionResult Index()
       {
            var model = Repository.Applications;
        
           return View("Index");
       }
       // get için kullanılır
       public IActionResult Apply()
       {
        
           return View();
       }

         // post için kullanılır
         [HttpPost] // formdan gelen veriyi almak için
         [ValidateAntiForgeryToken] // hangi tarayıcıyla çalışıyorsa onunla çalışır ve güvenlik sağlar
       public IActionResult Apply([FromForm] Candidate model)
       {
            Repository.Add(model);
            
           return View("Feedback",model);

       }
    
    }
}

