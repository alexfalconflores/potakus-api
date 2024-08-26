using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PotakusAPI.Models;

public class Theme
{
    [Key]
    [Column("ThemeId")]
    public int Id { get; set; }
    [Column("ThemeName")]
    public string? Name { get; set; } = string.Empty;
}
