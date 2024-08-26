using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace PotakusAPI.Models;

public class UserSession
{
    [Key]
    [Column("SessionId")]
    public int Id { get; set; }
    public int UserId { get; set; }
    public DateTime? SessionStart { get; set; }
    public DateTime? SessionEnd { get; set; }
    public int? DurationMinutes { get; set; }
    public string? DeviceInfo { get; set; }
    public string? OperatingSystem { get; set; }
    public string? Language {  get; set; }
}
