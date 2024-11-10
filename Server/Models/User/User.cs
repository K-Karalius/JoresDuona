using JoresDuona.Server.Models.Schedule;
using JoresDuona.Server.Models.Service.Reservation;
using JoresDuona.Server.Models.User.Enum;

namespace JoresDuona.Server.Models.User;

public class User
{
    public int Id { get; set; }
    
    public int BusinessId { get; set; }
    public Business.Business Business { get; set; }
    
    public string Username { get; set; }
    
    public string PasswordHash { get; set; }
    
    public string PasswordSalt { get; set; }
    
    public string Name { get; set; }
    
    public string Email { get; set; }
    
    public string Phone { get; set; }
    
    public string Address { get; set; }    
    
    public UserRole Role { get; set; }
    
    public EmploymentStatus EmploymentStatus { get; set; }
    
    public ICollection<Schedule.Schedule> Schedules { get; set; }
    public ICollection<TimeOff.TimeOff> TimeOffs { get; set; }
    public ICollection<DefaultShiftPattern> DefaultShiftPatterns { get; set; }
    public ICollection<Order.Order> Orders { get; set; }
    public ICollection<Service.Service> Services { get; set; }
    public ICollection<Reservation> Reservations { get; set; }
}