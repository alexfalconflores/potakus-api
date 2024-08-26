using PotakusAPI.Models;

namespace PotakusAPI.Repositories;

public interface IItemRepository
{
    Task<IEnumerable<Item>> GetAll();
    Task<Item> GetById(int id);
    Task<int> Add(Item item);
    Task<int> Update(Item updateItem);
    Task<int> DeleteById(int id);
}
