using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {
        private readonly List<Customer> _customers = new List<Customer>
        {
            new Customer { Id = 1, Name = "John Smith" },
            new Customer { Id = 2, Name = "Mary Williams" }
        };

        // GET: Customers
        public ActionResult Index()
        {
            var viewModel = new CustomersViewModel { Customers = _customers };

            return View(viewModel);
        }

        public ActionResult Details(int? id)
        {
            if (!id.HasValue)
                return View(ReturnNullCustomer());

            var customer = _customers.SingleOrDefault(c => c.Id == id);
            if (customer == null)
                return View(ReturnNullCustomer());

            return View(customer);
        }

        private Customer ReturnNullCustomer()
        {
            return null;
        }
    }
}