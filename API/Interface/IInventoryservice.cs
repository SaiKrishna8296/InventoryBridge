using Data.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Api.Interface
{
    public interface IInventoryservice
    {
        Task<IEnumerable<Inventory>> GetItems();
        Task<int> CreateItem(InventoryWithOutId inventory);
        Task<int> UpdateItem(InventoryWithOutId inventory, int id);
        Task<int> DeleteItem( int id);
        
    }
}
