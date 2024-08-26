using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace PotakusAPI.Models;

public class Item
{
    [Key]
    [Column("ItemId")]
    public int Id { get; set; }
    public string? Name { get; set; }
    public List<string>? AlternateNames { get; set; }
    public string? Description { get; set; }
    public List<string>? Category { get; set; }
    public string? Cover { get; set; }
    public string? Thumbnail { get; set; }
    public List<string>? Images { get; set; }
    public List<string>? VideoLinks { get; set; }
    public DateTime? CreatedAt { get; set; }
    public DateTime? UpdatedAt { get; set; }
    public int? CreatedByUser {  get; set; }
    public int? UpdatedByUser { get; set; }

}
