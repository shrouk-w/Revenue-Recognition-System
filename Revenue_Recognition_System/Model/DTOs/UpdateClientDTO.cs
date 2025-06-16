using System.ComponentModel.DataAnnotations;

namespace Revenue_Recognition_System.Model.DTOs;

public class UpdateClientDTO
{
    [MaxLength(100)]
    public string? Name { get; set; }
    [EmailAddress]
    public string? Email { get; set; }
    [MaxLength(100)]
    public string? Adress { get; set; }
    [Phone]
    public string? Phone { get; set; }
}