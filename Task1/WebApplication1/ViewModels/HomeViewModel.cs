using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;
namespace WebApplication1.ViewModels
{
    public class HomeViewModel
    {
        public List<Service> Services { get; set; } 

        public List<Featured> Featureds { get; set; }
    }
}
