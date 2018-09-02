using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {
        private ApplicationDbContext _context;

        public CustomersController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        public ViewResult Index()
        {
            var customers = _context.Customers.Include(c => c.MembershipType).ToList();

            return View(customers);
        }

        public ActionResult Details(int id)
        {
            var customer = _context.Customers.SingleOrDefault(c => c.Id == id);

            if (customer == null)
                return HttpNotFound();

            return View(customer);
        }

        #region MySolution
        /*
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
        */
        #endregion
    }
}