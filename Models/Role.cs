using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PotakusAPI.Models;

public class Role
{
    [Key]
    [Column("RoleId")]
    public Guid Id { get; set; }
    [Column("RoleName")]
    public string? Name { get; set; } = string.Empty;
    [Column("Description")]
    public string? Description { get; set; }
}
