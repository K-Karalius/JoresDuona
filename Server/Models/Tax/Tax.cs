using JoresDuona.Server.Models.Order.Items.Tax;

namespace JoresDuona.Server.Models.Tax;

public class Tax
{
    public int Id { get; set; }
    
    public int BusinessId { get; set; }
    
    public Business.Business Business { get; set; }
    
    public string Name { get; set; }
    
    public decimal Amount { get; set; }
    
    public bool IsPercentage { get; set; }
    
    public ICollection<OrderItemTax> OrderItemTaxes { get; set; }
}