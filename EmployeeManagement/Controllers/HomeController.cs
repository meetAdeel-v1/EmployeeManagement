using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Controllers
{
    public class HomeController:Controller
    {
        public HomeController()
        {

        }
        public string index()
        {
            return "Hello from Home Controller Index";
        }
    }
}
