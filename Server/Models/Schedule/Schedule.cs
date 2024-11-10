using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JoresDuona.Server.Models.Schedule;

public class Schedule
{
    public int Id { get; set; }
    
    public int UserId { get; set; }
    
    public User.User User { get; set; }
    
    public DateTime StartTime { get; set; }
    
    public DateTime EndTime { get; set; }

    public DateTime LastUpdate { get; set; }

}