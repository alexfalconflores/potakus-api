using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace PotakusAPI.Models;

public class UserLoginAttempt
{
    [Key]
    [Column("AttemptId")]
    public int Id { get; set; }
    public int? UserId { get; set; }
    public DateTime? AttemptedAt { get; set; }
    public string? IPAddress { get; set; }
    public bool? WasSuccessful { get; set; }
    public string? FailureReason { get; set; }

}
