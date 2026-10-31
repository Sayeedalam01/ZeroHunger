using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Models
{
    public class FoodItemModel
    {
        public int Id { get; set; }

        public int CollectRequestId { get; set; }

        public string Name { get; set; } = null!;

        public int Quantity { get; set; }

        public string Unit { get; set; } = null!;
    }
}
