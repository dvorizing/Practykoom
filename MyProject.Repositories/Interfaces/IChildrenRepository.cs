using MyProject.Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Repositories.Interfaces
{
    public interface IChildrenRepository
    {
        Task<List<Child>> GetAllAsync();

        Task<Child> GetByIdAsync(string id);

        Task<Child> AddAsync(Child child);

        Task<Child> UpdateAsync( Child child);

        Task DeleteAsync(string id);
    }
}
