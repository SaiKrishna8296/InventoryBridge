using Data.Interface;
using Data.Models;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using System.Data;
using System.Data.SqlTypes;

namespace Data.Repositories
{
    public class InventoryRepository : IInventoryRepository
    {
        public readonly SampleContext _sampleContext;
        public InventoryRepository(SampleContext sampleContext)
        {
            _sampleContext = sampleContext;

        }

        public async Task<int> CreateItem(InventoryWithOutId inventory)
        {
            Inventory objInventory = new Inventory();
            objInventory.ItemNo = inventory.ItemNo;
            objInventory.Cost = inventory.Cost;
            objInventory.Description = inventory.Description;
            objInventory.Manufacturer = inventory.Manufacturer;
            objInventory.Name = inventory.Name;
            objInventory.StockQantity = inventory.StockQantity;

            var result= _sampleContext.Inventories.Add(objInventory);
            return await _sampleContext.SaveChangesAsync();

            
        }

        public async Task<int> DeleteItem(int id)
        {
            var item=_sampleContext.Inventories.Where(x => x.Id == id).Select(x => x).FirstOrDefault();
            _sampleContext.Inventories.Remove(item);
            return await _sampleContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<Inventory>> GetItems()
        {
            return await _sampleContext.Inventories.ToListAsyncUncommited();
                
        }

        public async Task<int> UpdateItem(InventoryWithOutId inventory,int id)
        {
            var objInventory = _sampleContext.Inventories.Where(x=>x.Id==id).Select(x=>x).FirstOrDefault();
            if (objInventory != null)
            {
                objInventory.ItemNo = inventory.ItemNo;
                objInventory.Cost = inventory.Cost;
                objInventory.Description = inventory.Description;
                objInventory.Manufacturer = inventory.Manufacturer;
                objInventory.Name = inventory.Name;
                objInventory.StockQantity = inventory.StockQantity;
            }

            return await _sampleContext.SaveChangesAsync();
        }
    }
}
