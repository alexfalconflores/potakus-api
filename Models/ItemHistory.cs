using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace PotakusAPI.Models;

public class ItemHistory
{
    [Key]
    [Column("HistoryId")]
    public int Id { get; set; }
    public int? ItemId { get; set; }
    public int? UpdatedByUser { get; set; }
    public string? Changes { get; set; }
    public DateTime? UpdatedAt { get; set; }
}
