using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Vidley.Dtos;
using Vidley.Models;
using System.Data.Entity;
using AutoMapper;

namespace Vidley.Api
{
    public class CustomersController : ApiController
    { 
        private ApplicationDbContext _context;
        public CustomersController()
            {
            _context=new ApplicationDbContext();
            }
        public IHttpActionResult GetCustomers(string query=null)
        {
            var customersQuery = _context.Customers
                .Include(c => c.MembershipType);
            //if (!string.IsNullOrWhiteSpace(query))
            //    customersQuery = customersQuery.Where(c => c.Name.Contains(query));
                var customerDtos=customersQuery 
                .ToList()
                .Select(Mapper.Map<Customer,CustomerDto>);
            return Ok(customerDtos);
        }
        public IHttpActionResult GetCustomer(int id)
        {
            var customer = _context.Customers.SingleOrDefault(c => c.Id==id);
            if (customer == null)
                return NotFound();
            return Ok(Mapper.Map<Customer,CustomerDto>(customer));
        }
        [HttpPost]
        public IHttpActionResult CreateCustomer(CustomerDto customer)
        {
            if (!ModelState.IsValid)
                return BadRequest();
            var customerr = Mapper.Map<CustomerDto, Customer>(customer);
            _context.Customers.Add(customerr);
            _context.SaveChanges();
            customer.Id = customerr.Id;
            customer.Id=customerr.Id;
            return Created(new Uri(Request.RequestUri + "/" + customerr.Id), customer);
        }
        [HttpPut]
         public void UpdateCustomer(int id,CustomerDto customer)
        {
            if (!ModelState.IsValid)
                throw new HttpResponseException(HttpStatusCode.BadRequest);
            var customerInDb = _context.Customers.SingleOrDefault(c => c.Id == id);
            if (customerInDb == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);
            Mapper.Map(customer, customerInDb);
          
            _context.SaveChanges();
           
        }
        [HttpDelete]
        public IHttpActionResult DeleteCustomer(int id)
        {
            var customerInDb = _context.Customers.SingleOrDefault(c => c.Id == id);
            if (customerInDb == null)
               return NotFound();
            _context.Customers.Remove(customerInDb);
            _context.SaveChanges();
            return Ok();
      
        
        }
        
    }
}
