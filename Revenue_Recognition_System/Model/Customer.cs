using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using Revenue_Recognition_System.Model.DTOs;

namespace Revenue_Recognition_System.Model;

public class Customer
{
    [Key]
    public int CustomerId { get; set; }
    [MaxLength(100)]
    public string Name { get; set; }
    [EmailAddress]
    public string Email { get; set; }
    [MaxLength(100)]
    public string Adress { get; set; }
    [Phone]
    public string Phone { get; set; }
    [Length(11,11)]
    public string? PESEL { get; set; }
    [Length(10,10)]
    public string? KRS { get; set; }
    public bool Active { get; set; }
    
    public void Delete()
    {
        if (!this.Active)
            throw new BadRequestException("this Customer is already deleted");
        if (KRS is not null)
            throw new BadRequestException("firms cannot be deleted");
        this.Active = false;
    }

    public void Autheticate()
    {
        if (KRS is null && PESEL is null)
            throw new BadRequestException("KRS or PESEL is required");
        if (KRS is not null && PESEL is not null)
            throw new BadRequestException("Customer can have either KRS or PESEL, not both");
    }

    public void Update([FromBody] UpdateClientDTO customerDTO)
    {
        if (!this.Active)
            throw new ConflictException("cannot update deleted customers");
        this.Name = customerDTO.Name ?? this.Name;
        this.Email = customerDTO.Email ?? this.Email;
        this.Adress = customerDTO.Adress ?? this.Adress;
        this.Phone = customerDTO.Phone ?? this.Phone;
    }
}