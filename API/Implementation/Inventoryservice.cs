using Api.Interface;
using Data.Interface;
using Data.Models;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Api.Implementation
{
    public class Inventoryservice : IInventoryservice
    {
        public readonly IInventoryRepository _IInventoryservice;
        public readonly IConfiguration _IConfiguration;

        public Inventoryservice(IInventoryRepository iInventoryservice, IConfiguration iConfiguration)
        {
            _IInventoryservice = iInventoryservice;
            _IConfiguration = iConfiguration;
        }

        public async Task<int> CreateItem(InventoryWithOutId inventory)
        {
            return await _IInventoryservice.CreateItem(inventory);
        }

        public async Task<int> DeleteItem(int id)
        {
            return await _IInventoryservice.DeleteItem(id);
        }

        public async Task<IEnumerable<Inventory>> GetItems()
        {
            return await _IInventoryservice.GetItems();
        }

        public async Task<int> UpdateItem(InventoryWithOutId inventory, int id)
        {
            return await _IInventoryservice.UpdateItem(inventory, id);
        }
    }
}
