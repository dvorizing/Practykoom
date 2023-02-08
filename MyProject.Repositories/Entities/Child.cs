using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Repositories.Entities
{
    public class Child
    {
        public string? Id { get; set; }
        public string? FamilyName { get; set; }
        public DateTime DateBorn { get; set; }
        public string? ParentId { get; set; }
    }
}
