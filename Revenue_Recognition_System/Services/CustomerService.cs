using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Revenue_Recognition_System.DAL;
using Revenue_Recognition_System.Model;
using Revenue_Recognition_System.Model.DTOs;

namespace Revenue_Recognition_System.Services;

public class CustomerService : ICustomerService
{
    private readonly RRSDbContext _context;

    public CustomerService(RRSDbContext context)
    {
        _context = context;
    }
    
    public async Task<int> AddCustomerAsync([FromBody]AddCustomerDTO customer, CancellationToken token)
    {
        var customerToAdd = new Customer
        {
            Name = customer.Name,
            Email = customer.Email,
            Phone = customer.Phone,
            PESEL = customer.PESEL,
            KRS = customer.KRS,
            Adress = customer.Adress,
            Active = true
        };
        
        customerToAdd.Autheticate();
        
        await _context.Customers.AddAsync(customerToAdd, token);
        
        await _context.SaveChangesAsync(token);

        return customerToAdd.ClientId;
    }

    public async Task DeleteCustomerAsync(int id, CancellationToken token)
    {
        if(id<=0)
            throw new BadRequestException("Invalid id");
        var customerToDelete = await _context.Customers.FindAsync(id, token);
        
        customerToDelete.Delete();
        
        await _context.SaveChangesAsync(token);
    }

    public async Task<Customer> UpdateCustomerAsync(int id, UpdateClientDTO customer, CancellationToken token)
    {
        if(id<=0)
            throw new BadRequestException("Invalid id");
        
        var toEdit = await _context.Customers.FindAsync(id, token);
        
        toEdit.Update(customer);
        
        await _context.SaveChangesAsync(token);
        
        return toEdit;
    }
}