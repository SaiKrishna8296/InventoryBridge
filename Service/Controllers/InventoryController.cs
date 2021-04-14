using Api.Interface;
using Ascend.MUService.Service.Controllers;
using Data.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sampleproject.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class InventoryController : BaseController
    {
        public readonly IInventoryservice _IInventoryservice;
        public InventoryController(
            IConfiguration configuration,
            ILogger<BaseController> logger,
            IInventoryservice inventoryservice) : base(configuration, logger)
        {
            _IInventoryservice = inventoryservice;
        }
        [HttpGet]
        [Route("Items")]
        public async Task<IActionResult> Get()
        {
            try
            {
                var ItemsList = await _IInventoryservice.GetItems();
                return Ok(ItemsList);
            }
            catch (Exception ex)
            {
                throw;
            }


        }

        [HttpPost]
        [Route("createItem")]
        public async Task<IActionResult> AddItem([FromBody] InventoryWithOutId inventory)
        {
            try
            {
                var ItemsList = await _IInventoryservice.CreateItem(inventory);
                return Ok(ItemsList);
            }
            catch (Exception ex)
            {
                throw;
            }


        }
        [HttpPut]
        [Route("updateItem/{id}")]
        public async Task<IActionResult> UpdateItem(InventoryWithOutId inventory, int id)
        {

            try
            {
                var result = await _IInventoryservice.UpdateItem(inventory, id);
                return Ok(result);
            }

            catch (Exception ex)
            {
                throw;
            }



        }
        [HttpDelete]
        [Route("deleteItem")]
        public async Task<IActionResult> DeleteItem( int id)
        {

            try
            {
                var result = await _IInventoryservice.DeleteItem(id);
                return Ok(result);
            }

            catch (Exception ex)
            {
                throw;
            }



        }
    }

}