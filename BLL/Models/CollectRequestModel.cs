using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Models
{
    public class CollectRequestModel
    {
        public int Id { get; set; }

        public int RestaurantId { get; set; }

        public int EmployeeId { get; set; }

        public DateTime PreserveUntil { get; set; }

        public string Status { get; set; } = null!;

        public DateTime CreatedAt { get; set; }

        public DateTime CollectedAt { get; set; }

        public DateTime DistributedAt { get; set; }

        public DateTime CompletedAt { get; set; }
    }
}
