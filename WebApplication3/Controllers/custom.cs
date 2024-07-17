using Microsoft.AspNetCore.Mvc;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    public class custom : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Custome()
        {
            return View();
        }
        public IActionResult Customer3(customer2 data)
        {
            using (var entity = new CustomerContext()) 
            {
                Table_1 cus = new Table_1();
             
                cus.Customer_Name = data.CustomerName;
                cus.Customer_Address = data.CustomerAddress;

                entity.Table_1.Add(cus);
                entity.SaveChanges();
            }
            return View();
        }

    }
}
