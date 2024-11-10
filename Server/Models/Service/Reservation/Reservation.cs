using JoresDuona.Server.Models.Service.Reservation.Enum;

namespace JoresDuona.Server.Models.Service.Reservation;

public class Reservation
{
    public int Id { get; set; }
    
    public int EmployeeId { get; set; }
    
    public User.User Employee { get; set; }
    
    public int CustomerId { get; set; }
    
    public Customer Customer { get; set; }
    
    public int ServiceId { get; set; }
    
    public Service Service { get; set; }
    
    public int OrderId { get; set; }
    
    public Order.Order Order { get; set; }
    
    public string CustomerName { get; set; }
    
    public string CustomerEmail { get; set; }
    
    public string CustomerPhone { get; set; }
    
    public int NumberOfGuests { get; set; }
    
    public DateTime BookedAt { get; set; }
    
    public DateTime ReservationTime { get; set; }
    
    public ReservationStatus Status { get; set; }
    
    public ICollection<Notification> Notifications { get; set; }
}