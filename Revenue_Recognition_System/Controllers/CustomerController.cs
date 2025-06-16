using Microsoft.AspNetCore.Mvc;
using Revenue_Recognition_System.Model;
using Revenue_Recognition_System.Model.DTOs;
using Revenue_Recognition_System.Services;

namespace Revenue_Recognition_System.Controllers;
[ApiController]
[Route("api/[controller]")]
public class CustomerController : ControllerBase
{
    private readonly ICustomerService _customerService;

    public CustomerController(ICustomerService customerService)
    {
        _customerService = customerService;
    }
        
    
    [HttpPost]
    public async Task<IActionResult> AddCustomerAsync([FromBody] AddCustomerDTO customer, CancellationToken token)
    {
        var response = await _customerService.AddCustomerAsync(customer, token);
        return Created($"api/Customer/{response}",customer);
    }
    
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteCustomerAsync([FromRoute] int id, CancellationToken token)
    {
        await _customerService.DeleteCustomerAsync(id, token);
        return NoContent();
    }
    
}