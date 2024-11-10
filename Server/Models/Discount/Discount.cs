using JoresDuona.Server.Models.Order.Discount;
using JoresDuona.Server.Models.Order.Items.Discount;

namespace JoresDuona.Server.Models.Discount;

public class Discount
{
    public int Id { get; set; }
    
    public int BusinessId { get; set; }
    
    public Business.Business Business { get; set; }
    
    public string Description { get; set; }
    
    public decimal Amount { get; set; }
    
    public bool IsPercentage { get; set; }
    
    public DateOnly ValidFrom { get; set; }
    
    public DateOnly ValidTo { get; set; }
    
    public ICollection<OrderDiscount> OrderDiscounts { get; set; }
    
    public ICollection<OrderItemDiscount> OrderItemDiscounts { get; set; }
}