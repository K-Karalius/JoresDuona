using JoresDuona.Server.Models.Items;

namespace JoresDuona.Server.Models.Order.Items;

public class OrderItemVariation
{
    public int Id { get; set; }
    
    public int ItemVariationId { get; set; }
    
    public ItemVariation ItemVariation { get; set; }
    
    public int OrderItemId { get; set; }
    
    public OrderItem OrderItem { get; set; }
    
    public int Quantity { get; set; }
    
    public decimal AdditionalPrice { get; set; }
}