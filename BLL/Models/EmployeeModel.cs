using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Models
{
    public class EmployeeModel
    {
        public int Id { get; set; }

        public string Name { get; set; } = null!;

        public string Phone { get; set; } = null!;

        public string Email { get; set; } = null!;

        public string Address { get; set; } = null!;

        public string IsAvailable { get; set; } = null!;
    }
}
