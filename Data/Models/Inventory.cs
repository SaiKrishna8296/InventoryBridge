using System;
using System.Collections.Generic;

#nullable disable

namespace Data.Models
{
    public partial class Inventory
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ItemNo { get; set; }
        public string Manufacturer { get; set; }
        public string Description { get; set; }
        public decimal Cost { get; set; }
        public int StockQantity { get; set; }
    }
    public partial class InventoryWithOutId
    {
        
        public string Name { get; set; }
        public string ItemNo { get; set; }
        public string Manufacturer { get; set; }
        public string Description { get; set; }
        public decimal Cost { get; set; }
        public int StockQantity { get; set; }
    }
}
