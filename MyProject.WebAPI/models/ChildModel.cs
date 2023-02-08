using MyProject.Repositories.Entities;

namespace MyProject.WebAPI.models
{
    public class ChildModel
    {
        public string? Id { get; set; }
        public string? FamilyName { get; set; }
        public DateTime DateBorn { get; set; }
        public string? ParentId { get; set; }
    }
}
