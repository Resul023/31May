using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;
using WebApplication1.ViewModels;
namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {

            List<Service> services = new List<Service>
            {
                new Service
                {
                Id=1,
                Icon = "bx bxl-dribbble",
                Title = "Lorem Ipsum",
                Content = "Voluptatum deleniti atque corrupti quos dolores et quas molestias excepturi"
                },

                 new Service
                {
                Id=2,
                Icon = "bx bx-file",
                Title = "Sed ut perspiciatis",
                Content = "Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore"
                },

                  new Service
                {
                Id=3,
                Icon = "bx bx-tachometer",
                Title = "Magni Dolores",
                Content = "Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia"
                },

                   new Service
                {
                Id=4,
                Icon = "bx bx-world",
                Title = "Nemo Enim",
                Content = "At vero eos et accusamus et iusto odio dignissimos ducimus qui blanditiis"
                },

                    new Service
                {
                Id=5,
                Icon = "bx bx-slideshow",
                Title = "Dele cardo",
                Content = "Quis consequatur saepe eligendi voluptatem consequatur dolor consequuntur"
                },

                     new Service
                {
                Id=6,
                Icon = "bx bx-arch",
                Title = "Divera don",
                Content = "Modi nostrum vel laborum. Porro fugit error sit minus sapiente sit aspernatur"
                },


            };
            List<Featured> featureds = new List<Featured> 
            { 
                new Featured
                { 
                Id=1,
                Icon= "bi bi-card-checklist",
                Title="Lorem Ipsum",
                Content="Voluptatum deleniti atque corrupti quos dolores et quas molestias excepturi sint occaecati cupiditate non provident"
                },

                 new Featured
                {
                Id=2,
                Icon= "bi bi-bar-chart",
                Title="Dolor Sitema",
                Content="Minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat tarad limino ata"
                },

                  new Featured
                {
                Id=3,
                Icon= "bi bi-binoculars",
                Title="Sed ut perspiciatis",
                Content="Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur"
                }
            };
            HomeViewModel newView = new HomeViewModel 
            { 
            Services = services,
            Featureds = featureds,
            
            };
            return View(newView);
        }

        public IActionResult About() 
        {
            return View();
        }

        public IActionResult Services()
        {
            List<Service> services = new List<Service>
            {
                new Service
                {
                Id=1,
                Icon = "bx bxl-dribbble",
                Title = "Lorem Ipsum",
                Content = "Voluptatum deleniti atque corrupti quos dolores et quas molestias excepturi"
                },

                 new Service
                {
                Id=2,
                Icon = "bx bx-file",
                Title = "Sed ut perspiciatis",
                Content = "Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore"
                },

                  new Service
                {
                Id=3,
                Icon = "bx bx-tachometer",
                Title = "Magni Dolores",
                Content = "Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia"
                },

                   new Service
                {
                Id=4,
                Icon = "bx bx-world",
                Title = "Nemo Enim",
                Content = "At vero eos et accusamus et iusto odio dignissimos ducimus qui blanditiis"
                },

                    new Service
                {
                Id=5,
                Icon = "bx bx-slideshow",
                Title = "Dele cardo",
                Content = "Quis consequatur saepe eligendi voluptatem consequatur dolor consequuntur"
                },

                     new Service
                {
                Id=6,
                Icon = "bx bx-arch",
                Title = "Divera don",
                Content = "Modi nostrum vel laborum. Porro fugit error sit minus sapiente sit aspernatur"
                },


            };
            List<Featured> featureds = new List<Featured>
            {
                new Featured
                {
                Id=1,
                Icon= "bi bi-card-checklist",
                Title="Lorem Ipsum",
                Content="Voluptatum deleniti atque corrupti quos dolores et quas molestias excepturi sint occaecati cupiditate non provident"
                },

                 new Featured
                {
                Id=2,
                Icon= "bi bi-bar-chart",
                Title="Dolor Sitema",
                Content="Minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat tarad limino ata"
                },

                  new Featured
                {
                Id=3,
                Icon= "bi bi-binoculars",
                Title="Sed ut perspiciatis",
                Content="Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur"
                }
            };
            HomeViewModel newView = new HomeViewModel
            {
                Services = services,
                Featureds = featureds,

            };
            return View(newView);
        }
        public IActionResult Portfolio() 
        {
            return View();
        }

        public IActionResult Detail(int id) 
        {
            List<Service> services = new List<Service>
            {
                new Service
                {
                Id=1,
                Icon = "bx bxl-dribbble",
                Title = "Lorem Ipsum",
                Content = "Voluptatum deleniti atque corrupti quos dolores et quas molestias excepturi"
                },

                 new Service
                {
                Id=2,
                Icon = "bx bx-file",
                Title = "Sed ut perspiciatis",
                Content = "Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore"
                },

                  new Service
                {
                Id=3,
                Icon = "bx bx-tachometer",
                Title = "Magni Dolores",
                Content = "Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia"
                },

                   new Service
                {
                Id=4,
                Icon = "bx bx-world",
                Title = "Nemo Enim",
                Content = "At vero eos et accusamus et iusto odio dignissimos ducimus qui blanditiis"
                },

                    new Service
                {
                Id=5,
                Icon = "bx bx-slideshow",
                Title = "Dele cardo",
                Content = "Quis consequatur saepe eligendi voluptatem consequatur dolor consequuntur"
                },

                     new Service
                {
                Id=6,
                Icon = "bx bx-arch",
                Title = "Divera don",
                Content = "Modi nostrum vel laborum. Porro fugit error sit minus sapiente sit aspernatur"
                },


            };
            
            var srv = services.Find(x => x.Id == id);
            return View(srv);
        }
    }
}
