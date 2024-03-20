using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Runtime.InteropServices;
using System.Web.Http;
using Vidly.Models;

namespace Vidly.Controllers.Api
{
    public class CustomersController : ApiController
    {
        private readonly ApplicationDbContext _context;

        public CustomersController()
        {
            _context = new ApplicationDbContext();
        }

        // GET /api/customers
        public IEnumerable<Customer> GetCustomers()
        {
            return _context.Customers.ToList();
        }

        // GET /api/customers/1
        public Customer GetCustomer(int id)
        {
            var customer = _context.Customers.SingleOrDefault(c => c.Id == id);
            if (customer == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);
            else
                return customer;
        }

        // POST /api/customers
        [HttpPost]
        public Customer CreateCustomer(Customer customer)
        {
            if (!ModelState.IsValid)
                throw new HttpResponseException(HttpStatusCode.BadRequest);

            _context.Customers.Add(customer);
            _context.SaveChanges();

            return customer;
        }

        // PUT /api/customers/1
        [HttpPut]
        public void UpdateCustomer(int id, Customer customer)
        {
            if (!ModelState.IsValid)
                throw new HttpResponseException(HttpStatusCode.BadRequest);

            var existingCustomer = _context.Customers.SingleOrDefault(c => c.Id == id);
            if (existingCustomer == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }
            else
            {
                existingCustomer.Name = customer.Name;
                existingCustomer.BirthDate = customer.BirthDate;
                existingCustomer.IsSubscribedToNewsletter = customer.IsSubscribedToNewsletter;
                existingCustomer.MembershipTypeId = customer.MembershipTypeId;
                _context.SaveChanges();
            }
        }

        // DELETE /api/customers/1
        [HttpDelete]
        public void DeleteCustomer(int id)
        {
            var existingCustomer = _context.Customers.SingleOrDefault(c => c.Id == id);
            if (existingCustomer == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }
            else
            {
                _context.Customers.Remove(existingCustomer);
                _context.SaveChanges();
            }
        }
    }
}
