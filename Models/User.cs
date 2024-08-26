using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PotakusAPI.Models;

public class User
{
    [Key]
    [Column("UserId")]
    public int Id { get; set; }
    public Guid RoleId { get; set; }
    public string? Username { get; set; }
    public string? Firstname { get; set; }
    public string? Lastname { get; set; }
    public string? Bio {  get; set; }
    public DateOnly? DateOfBirth { get; set; }
    public string? PhoneNumber { get; set; }
    public string? ProfileImage {  get; set; }
    public int TotalLists { get; set; } = 0;
    public int ThemeId { get; set; } = 0;
    public string? PreferredLanguage { get; set; }
    public string? NotificationSettings { get; set; }
    public string? ModeratorNotes { get; set; }
    public string? Email { get; set; }
    public bool EmailConfirmed { get; set; } = false;
    public string? PasswordHash { get; set; }
    public string? Salt { get; set; }
    public string? VerificationToken { get; set; }
    public DateTime? VerificationTokenExpiry {  get; set; }
    public string? PasswordResetToken { get; set; }
    public DateTime? PasswordResetTokenExpiry { get; set; }
    public bool? IsExternalLogin { get; set; } = false;
    public string? Provider {  get; set; }
    public string? ProviderKey { get; set; }
    public bool? IsActive { get; set; } = true;
    public DateTime? LastLogin {  get; set; }
    public Guid? PreviousRoles {  get; set; }
    public int? FailedLoginAttempts { get; set; } = 0;
    public string? LegalConsents {  get; set; }
    public bool? TwoFactorEnabled { get; set; } = false;
    public string? TwoFactorMethod {  get; set; }
    public DateTime? PasswordChangedAt { get; set; }
    public DateTime? CreatedAt { get; set; }
    public DateTime? UpdatedAt { get; set; }

}
