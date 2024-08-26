using Microsoft.EntityFrameworkCore;
using PotakusAPI.Data;
using PotakusAPI.Models;

namespace PotakusAPI.Repositories;

public class ItemRepository(PotakuAppContext context) : IItemRepository
{
    public async Task<int> Add(Item item)
    {
        if (item is null) return 0;
        context.Items.Add(item);
        return await context.SaveChangesAsync();
    }

    public async Task<int> DeleteById(int id)
    {
        var item = await context.Items.FirstOrDefaultAsync(x => x.Id == id);
        if (item is null) return 0;
        context.Items.Remove(item);
        return await context.SaveChangesAsync();

    }

    public async Task<IEnumerable<Item>> GetAll()
    {
        return await context.Items.ToListAsync();
        //return await context.Items.FromSql($"EXEC ").ToListAsync();
    }

    public async Task<Item> GetById(int id)
    {
        return await context.Items.FirstOrDefaultAsync(x => x.Id == id);
    }

    public async Task<int> Update(Item updateItem)
    {
        var item = await context.Items.FirstOrDefaultAsync(x =>x.Id == updateItem.Id);
        if (item is null) return 0;
        item.Name = updateItem.Name;
        item.AlternateNames = updateItem.AlternateNames;
        item.Description = updateItem.Description;
        item.Category = updateItem.Category;
        item.Cover = updateItem.Cover;
        item.Thumbnail = updateItem.Thumbnail;
        item.Images = updateItem.Images;
        item.VideoLinks = updateItem.VideoLinks;
        context.Items.Update(item);
        return await context.SaveChangesAsync();
    }
}
