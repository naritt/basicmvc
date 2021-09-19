using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using basicmvc.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace basicmvc.Controllers
{
    public class ImageController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            List<Movie> movieList = new List<Movie>()
            {
                new Movie()
                {
                    name = "Loki",
                    description = "gawrgsafgasfgsfagfsag",
                    image = "https://img1.hotstarext.com/image/upload/f_auto,t_web_vl_3x/sources/r1/cms/prod/4371/1034371-v-79d8bc8a8ea8"
                },
                new Movie()
                {
                    name = "Iron Man 3",
                    description = "agasgsf;gjlksfjgKLSGD",
                    image = "https://img1.hotstarext.com/image/upload/f_auto,t_web_vl_2_5x/sources/r1/cms/prod/2135/942135-v"
                }
            };

            return View(movieList);
        }
    }
}
