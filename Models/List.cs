using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace PotakusAPI.Models;

public class List
{
    [Key]
    [Column("ListId")]
    public int Id { get; set; }
    public int UserId { get; set; }
    public string? Name { get; set; }
    public bool? IsDefault { get; set; } = false;
}
