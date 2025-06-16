using System.ComponentModel.DataAnnotations;

namespace Revenue_Recognition_System.Model;

public class Customer
{
    [Key]
    public int ClientId { get; set; }
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
}