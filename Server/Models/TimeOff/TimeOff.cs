using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using JoresDuona.Server.Models.TimeOff.Enum;

namespace JoresDuona.Server.Models.TimeOff;

public class TimeOff
{
    public int Id { get; set; }
    
    public int UserId { get; set; }
    public User.User User { get; set; }
    
    public DateTime StartDate { get; set; }
    
    public DateTime EndDate { get; set; }
    
    public TimeOffReason Reason { get; set; }
    
    public string Comment { get; set; }
}