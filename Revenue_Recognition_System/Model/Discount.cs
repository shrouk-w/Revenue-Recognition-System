using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Revenue_Recognition_System.Model;

public class Discount
{
    [Key]
    public int DiscountId { get; set; }
    public int SoftwareId { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    [MaxLength(50)]
    public string DiscountTitle { get; set; }
    [Range(0, 100, ErrorMessage = "Discount must be between 0 and 100 %")]
    public decimal DiscountAmountInPercentage { get; set; }
    
    [ForeignKey("SoftwareId")]
    public Software Software { get; set; }
}