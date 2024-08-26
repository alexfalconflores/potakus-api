using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace PotakusAPI.Models;

public class ListItem
{
    [Key]
    [Column("ListItemId")]
    public int Id { get; set; }
    public int ListId { get; set; }
    public int ItemId { get; set; }
    public bool? Watched { get; set; } = false;
    public int? CurrentChapter { get; set; }
    public bool? Completed { get; set; } = false;
    public string? Status { get; set; }
}
