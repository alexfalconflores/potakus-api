using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace PotakusAPI.Models;

public class Permission
{
    [Key]
    [Column("PermissionId")]
    public int Id { get; set; }
    [Column("PermissionName")]
    public string? Name { get; set; } = string.Empty;
    public string? Description { get; set; }
}
