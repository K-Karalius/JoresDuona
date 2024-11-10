namespace JoresDuona.Server.Models.Order.Items.Tax;

public class OrderItemTax
{
    public int Id { get; set; }
    
    public int OrderItemId { get; set; }
    
    public OrderItem OrderItem { get; set; }
    
    public int TaxId { get; set; }
    
    public Models.Tax.Tax Tax { get; set; }
    
    public decimal Amount { get; set; }
}