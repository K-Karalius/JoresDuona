namespace JoresDuona.Server.Models.Order.Discount;

public class OrderDiscount
{
    public int Id { get; set; }
    
    public int OrderId { get; set; }
    
    public Order Order { get; set; }
    
    public int DiscountId { get; set; }
    
    public Models.Discount.Discount Discount { get; set; }
    
    public decimal Amount { get; set; }
}