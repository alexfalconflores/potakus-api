using Microsoft.EntityFrameworkCore;
using PotakusAPI.Data;
using PotakusAPI.Models;

namespace PotakusAPI.Repositories;

public class ThemeRepository(PotakuAppContext context) : IThemeRepository
{
    public async Task<int> Add(Theme theme)
    {
        if (theme is null) return 0;
        context.Themes.Add(theme);
        return await context.SaveChangesAsync();
    }

    public async Task<int> DeleteById(int id)
    {
        var theme = await context.Themes.FirstOrDefaultAsync(x => x.Id == id);
        if (theme is null) return 0;
        context.Themes.Remove(theme);
        return await context.SaveChangesAsync();
    }

    public async Task<IEnumerable<Theme>> GetAll()
    {
        return await context.Themes.ToListAsync();
    }

    public async Task<Theme> GetById(int id)
    {
        return await context.Themes.FirstOrDefaultAsync(x => x.Id == id);
    }

    public async Task<int> Update(Theme updateTheme)
    {
        var theme = await context.Themes.FirstOrDefaultAsync(x => x.Id == updateTheme.Id);
        if (theme is null) return 0;
        theme.Name = updateTheme.Name;
        return await context.SaveChangesAsync();
    }
}
