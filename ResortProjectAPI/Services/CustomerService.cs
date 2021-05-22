using Microsoft.EntityFrameworkCore;
using ResortProjectAPI.IServices;
using ResortProjectAPI.ModelEF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ResortProjectAPI.Services
{
    public class CustomerService:ICustomerService
    {
        private readonly ResortDBContext _context;

        public CustomerService(ResortDBContext context)
        {
            _context = context;
        }

        public async Task<int> Create(Customer customer)
        {
            _context.Customers.Add(customer);
            return await _context.SaveChangesAsync();
        }

        public async Task<int> Delete(string id)
        {
            var customer = await _context.Customers.FindAsync(id);
            _context.Customers.Remove(customer);
            return await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Customer>> GetAll()
        {
            return await _context.Customers.ToListAsync();
        }

        public async Task<Customer> GetByID(string id)
        {
            return await _context.Customers.FindAsync(id);
        }

        public async Task<int> Update(Customer entity)
        {
            var customer = await _context.Customers.FindAsync(entity.ID);
            customer.Name = entity.Name;
            customer.Birth = entity.Birth;
            customer.Phone = entity.Phone;
            customer.Gender = entity.Gender;
            customer.Password = entity.Password;
            return await _context.SaveChangesAsync();
        }
    }
}
