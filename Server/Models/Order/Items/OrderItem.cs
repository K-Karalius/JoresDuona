using JoresDuona.Server.Models.Items;
using JoresDuona.Server.Models.Order.Items.Discount;
using JoresDuona.Server.Models.Order.Items.Tax;

namespace JoresDuona.Server.Models.Order.Items;

public class OrderItem
{
    public int Id { get; set; }
    
    public int OrderId { get; set; }
    
    public Order Order { get; set; }
    
    public int ItemId { get; set; }
    
    public Item Item { get; set; }
    
    public int Quantity { get; set; }
    
    public decimal Price { get; set; }
    
    public ICollection<OrderItemVariation> OrderItemVariations { get; set; }
    
    public ICollection<OrderItemTax> OrderItemTaxes { get; set; }
    
    public ICollection<OrderItemDiscount> OrderItemDiscounts { get; set; }
}