using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JoresDuona.Server.Models.Schedule;

public class DefaultShiftPattern
{
    public int Id { get; set; }
    
    public DayOfWeek DayOfWeek { get; set; }
    
    public DateTime StartDate { get; set; }
    
    public DateTime EndDate { get; set; }
    
    public ICollection<User.User> Users { get; set; }
}
