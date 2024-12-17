using Microsoft.AspNetCore.Mvc;
using OrangeStore.Models;

namespace OrangeStore.Controllers
{
    public class UserController : Controller
    {
        public IActionResult UserList()
        {
            User user = new User(10001, "Prashanti", "Prashanti@gmail.com"); //sending data to view
            return View(user);
        }

        public IActionResult StudentInfo()
        {
            return View(new Student() { Name = "Ram", City = "Kathmandu" });
        }
        

        public IActionResult Login()
        {
            return View();
        }
        public IActionResult Add()
        {
            return View();
        }
        public IActionResult Edit()
        {
            return View();
        }
        public IActionResult Delete()
        {
            return View();
        }
    }
}

  
  
