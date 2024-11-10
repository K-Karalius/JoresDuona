using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using JoresDuona.Server.Models.Business;

namespace JoresDuona.Server.Models.Service;

public class Service
{
    
    public int Id { get; set; }

    public int BusinessId { get; set; }
    
    public Business.Business Business { get; init; }
    
    public int EmployeeId { get; set; }
    
    public User.User Employee { get; set; }
    
    public string Name { get; set; }
    
    public string Description { get; set; }
    
    public int DurationInMinutes { get; set; }
    
    public decimal BasePrice { get; set; }
    
    public ICollection<Reservation.Reservation> Reservations { get; set; }
    public ICollection<OrderService> OrderServices { get; set; }
}