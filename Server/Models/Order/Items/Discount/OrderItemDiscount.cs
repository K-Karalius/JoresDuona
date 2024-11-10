namespace JoresDuona.Server.Models.Order.Items.Discount;

public class OrderItemDiscount
{
    public int Id { get; set; }
    
    public int OrderItemId { get; set; }
    
    public OrderItem OrderItem { get; set; }
    
    public int DiscountId { get; set; }
    
    public Models.Discount.Discount Discount { get; set; }
    
    public decimal Amount { get; set; }
}