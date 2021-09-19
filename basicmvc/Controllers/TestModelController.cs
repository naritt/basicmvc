using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using basicmvc.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace basicmvc.Controllers
{
    public class TestModelController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            UserModel user = new UserModel();
            user.firstname = "Narit";
            user.lastname = "Trachuentong";

            return View(user);
        }

        public IActionResult List()
        {
            List<UserModel> userList = new List<UserModel>()
            {
                new UserModel()
                {
                    firstname = "Narit",
                    lastname = "Trachuentong"
                },
                new UserModel()
                {
                    firstname = "Nisakarn",
                    lastname = "Thanasinpaisan"
                },
                new UserModel()
                {
                    firstname = "Nakkarin",
                    lastname = "Trachuentong"
                },
                new UserModel()
                {
                    firstname = "Itsarate",
                    lastname = "Trachuentong"
                }
            };

            return View(userList);
        }
    }
}
