using PotakusAPI.Models;

namespace PotakusAPI.Repositories;

public interface IThemeRepository
{
    Task<IEnumerable<Theme>> GetAll();
    Task<Theme> GetById(int id);
    Task<int> Add(Theme theme);
    Task<int> Update(Theme updateTheme);
    Task<int> DeleteById(int id);
}
