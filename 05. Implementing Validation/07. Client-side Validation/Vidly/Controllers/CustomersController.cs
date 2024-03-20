using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {
        private ApplicationDbContext _context;

        public CustomersController()
        {
            _context = new ApplicationDbContext();
        }

        public ActionResult Index()
        {
            var customers = _context.Customers
                .Include(c => c.MembershipType)
                .ToList();
            return View(customers);
        }
        
        public ActionResult Details(int id)
        {
            var customer = _context.Customers
                .Include(c => c.MembershipType)
                .SingleOrDefault(x => x.Id == id);
            if (customer == null)
                return HttpNotFound();

            return View(customer);
        }

        public ActionResult New()
        {
            var membershiptypes = _context.MembershipTypes.ToList();
            var viewModel = new CustomerFormVM
            {
                Customer = new Customer(),
                MembershipTypes = membershiptypes,
            };

            return View("CustomerForm", viewModel);
        }

        public ActionResult Edit(int id)
        {
            var customer = _context.Customers.SingleOrDefault(c => c.Id == id);
            if (customer == null)
                return HttpNotFound();

            var viewModel = new CustomerFormVM
            {
                Customer = customer,
                MembershipTypes = _context.MembershipTypes.ToList(),
            };

            return View("CustomerForm", viewModel);
        }

        [HttpPost]
        public ActionResult Save(CustomerFormVM model)
        {
            // Get access to the validation result of "CustomerFormVM" which contains Customer class
            if (!ModelState.IsValid)
            {
                // If the customer is not valid, return back to the form
                model.MembershipTypes = _context.MembershipTypes.ToList();
                return View("CustomerForm", model);
            }

            if (model.Customer.Id == 0)
            {
                _context.Customers.Add(model.Customer);
            }
            else
            {
                var existingCustomer = _context.Customers.Single(c => c.Id == model.Customer.Id);
                existingCustomer.Name = model.Customer.Name;
                existingCustomer.BirthDate = model.Customer.BirthDate;
                existingCustomer.MembershipTypeId = model.Customer.MembershipTypeId;
                existingCustomer.IsSubscribedToNewsletter = model.Customer.IsSubscribedToNewsletter;
            }
            _context.SaveChanges();

            return RedirectToAction("Index", "Customers");
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
    }
}