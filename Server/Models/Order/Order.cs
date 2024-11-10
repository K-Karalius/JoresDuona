using JoresDuona.Server.Models.Order.Discount;
using JoresDuona.Server.Models.Order.Enum;
using JoresDuona.Server.Models.Order.Items;
using JoresDuona.Server.Models.Service;
using JoresDuona.Server.Models.Service.Reservation;

namespace JoresDuona.Server.Models.Order;

public class Order
{
    public int Id { get; set; }
    
    public int UserId { get; set; }
    
    public User.User User { get; set; }
    
    public DateTime CreatedAt { get; set; }
    
    public DateTime? ClosedAt { get; set; }
    
    public OrderStatus Status { get; set; }
    
    public decimal ChargeAmount { get; set; }

    public decimal DiscountAmount { get; set; }

    public decimal TaxAmount { get; set; }

    public decimal TipAmount { get; set; }
    
    public Reservation? Reservation { get; set; }
    public ICollection<OrderItem> OrderItems { get; set; }
    public ICollection<Payment.Payment> Payments { get; set; }
    public ICollection<OrderDiscount> OrderDiscounts { get; set; }
    public ICollection<OrderService> OrderServices { get; set; }
    
}