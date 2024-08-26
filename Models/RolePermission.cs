using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace PotakusAPI.Models;

public class RolePermission
{
    [Key]
    [Column("RolePermissionId")]
    public int Id { get; set; }
    public int RoleId { get; set; }
    public int PermissionId { get; set; }
}
