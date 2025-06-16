using System.ComponentModel.DataAnnotations;

namespace Revenue_Recognition_System.Model.DTOs;

public class AddCustomerDTO
{
    [Required]
    [MaxLength(100)]
    public string Name { get; set; }
    [Required]
    [EmailAddress]
    public string Email { get; set; }
    [Required]
    [MaxLength(100)]
    public string Adress { get; set; }
    [Required]
    [Phone]
    public string Phone { get; set; }
    [Length(11,11)]
    public string? PESEL { get; set; }
    [Length(10,10)]
    public string? KRS { get; set; }
}