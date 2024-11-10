using JoresDuona.Server.Models.Order.Items;

namespace JoresDuona.Server.Models.Items;

public class ItemVariation
{
    public int Id { get; set; }
    
    public int ItemId { get; set; }
    
    public Item Item { get; set; }

    public string Name { get; set; }
    
    public decimal AdditionalPrice { get; set; }
    
    public ICollection<OrderItemVariation> OrderItemVariations { get; set; }
}