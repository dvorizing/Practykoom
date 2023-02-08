using MyProject.Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Common.DTO
{
    public class ChildDTO
    {
        public string? Id { get; set; }
        public string? FamilyName { get; set; }
        public DateTime DateBorn { get; set; }
        public string? ParentId { get; set; }
    }
}
