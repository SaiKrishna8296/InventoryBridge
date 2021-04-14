using Data.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Data.Interface
{
    public interface  IInventoryRepository
    {
        Task<IEnumerable<Inventory>> GetItems();
        Task<int> CreateItem(InventoryWithOutId inventory);
        Task<int> UpdateItem(InventoryWithOutId inventory, int id);
        Task<int> DeleteItem(int id);
    }
}
