using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Web.Http;
using AutoMapper;
using Vidly.Dtos;
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
        public IEnumerable<CustomerDto> GetCustomers()
        {
            return _context.Customers.ToList()
                .Select(Mapper.Map<Customer, CustomerDto>);
        }

        // GET /api/customers/1
        public IHttpActionResult GetCustomer(int id)
        {
            var customer = _context.Customers.SingleOrDefault(c => c.Id == id);
            if (customer == null)
                //throw new HttpResponseException(HttpStatusCode.NotFound);
                return NotFound();
            else
            {
                //return Mapper.Map<Customer, CustomerDto>(customer);
                var customerDto = Mapper.Map<Customer, CustomerDto>(customer);
                return Ok(customerDto);
            }
        }

        // POST /api/customers
        [HttpPost]
        public IHttpActionResult CreateCustomer(CustomerDto customerDto)        // notice the return type
        {
            if (!ModelState.IsValid)
                //throw new HttpResponseException(HttpStatusCode.BadRequest);
                return BadRequest();

            var customer = Mapper.Map<CustomerDto, Customer>(customerDto);
            _context.Customers.Add(customer);
            _context.SaveChanges();

            customerDto.Id = customer.Id;
            //return customerDto;

            var uri = new Uri(Request.RequestUri + "/" + customer.Id);
            return Created(uri, customerDto);                                   // we use the helper method Created() from ApiController
        }

        // PUT /api/customers/1
        [HttpPut]
        public void UpdateCustomer(int id, CustomerDto customerDto)
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
                Mapper.Map(customerDto, existingCustomer);
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
