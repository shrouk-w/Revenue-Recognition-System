using System.ComponentModel.DataAnnotations;

namespace Revenue_Recognition_System.Model;

public class Software
{
    [Key]
    public int SoftwareId { get; set; }
    [MaxLength(250)]
    public string Description { get; set; }
    public decimal PriceForOneYear { get; set; }
    public decimal CurrentVersion { get; set; }
    [MaxLength(20)]
    public string Category { get; set; }
}