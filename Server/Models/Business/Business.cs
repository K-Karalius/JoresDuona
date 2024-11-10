using JoresDuona.Server.Models.Business.Enum;
using JoresDuona.Server.Models.Items;

namespace JoresDuona.Server.Models.Business;

public class Business
{
    public int Id { get; set; }
    
    public string Name { get; set; }
    
    public string PhoneNumber { get; set; }
    
    public string Email { get; set; }
    
    public string Address { get; set; }
    
    public string VATCode { get; set; }
    
    public BusinessType Type { get; set; }
    
    public ICollection<User.User> Users { get; set; }
    public ICollection<Service.Service> Services { get; set; }
    public ICollection<Item> Items { get; set; }
    public ICollection<Discount.Discount> Discounts { get; set; }
    public ICollection<Tax.Tax> Taxes { get; set; }
}