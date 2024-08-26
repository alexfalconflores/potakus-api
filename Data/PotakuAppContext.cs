using Microsoft.EntityFrameworkCore;
using PotakusAPI.Models;

namespace PotakusAPI.Data;

public class PotakuAppContext(DbContextOptions<PotakuAppContext> options) : DbContext(options)
{
    public DbSet<Item> Items { get; set; }
    public DbSet<ItemHistory> ItemHistories { get; set; }
    public DbSet<List> Lists { get; set; }
    public DbSet<ListItem> ListItems { get; set; }
    public DbSet<Permission> Permissions { get; set; }
    public DbSet<Role> Roles { get; set; }
    public DbSet<RolePermission> RolePermissions { get; set; }
    public DbSet<Theme> Themes { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<UserLogin> UserLogins { get; set; }
    public DbSet<UserLoginAttempt> UserLoginAttempts { get; set; }
    public DbSet<UserSession> UserSessions { get; set; }
}
