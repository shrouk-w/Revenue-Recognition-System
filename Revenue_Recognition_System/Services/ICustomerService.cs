using Microsoft.AspNetCore.Mvc;
using Revenue_Recognition_System.Model;
using Revenue_Recognition_System.Model.DTOs;

namespace Revenue_Recognition_System.Services;

public interface ICustomerService
{
    Task<int> AddCustomerAsync([FromBody]AddCustomerDTO customer, CancellationToken token);
    Task DeleteCustomerAsync(int id, CancellationToken token);
    Task<Customer> UpdateCustomerAsync(int id, UpdateClientDTO customer, CancellationToken token);
}