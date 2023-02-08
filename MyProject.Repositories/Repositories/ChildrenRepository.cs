using Microsoft.EntityFrameworkCore;
using MyProject.Repositories.Entities;
using MyProject.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Repositories.Repositories
{
    public class ChildrenRepository : IChildrenRepository
    {
        private readonly IContext _context;

        public ChildrenRepository(IContext context)
        {
            _context = context;
        }

        public async Task<Child> AddAsync(Child child)
        {
            var newchild = new Child();
            newchild.Id = child.Id;
            newchild.FamilyName = child.FamilyName;
            newchild.ParentId = child.ParentId;
            newchild.DateBorn = child.DateBorn;
            _context.Children.Add(newchild);
            await _context.SaveChangesAsync();
            return newchild;
        }

        public async Task DeleteAsync(string id)
        {
            _context.Children.Remove(await GetByIdAsync(id));
            await _context.SaveChangesAsync();
        }

        public async Task<List<Child>> GetAllAsync()
        {
            return await _context.Children.ToListAsync();
         
        }

        public async Task<Child> GetByIdAsync(string id)
        {
            return await _context.Children.FindAsync(id);
        }

        public async Task<Child> UpdateAsync( Child child)
        {
            Child newchild =await GetByIdAsync(child.Id);
            newchild.Id = child.Id;
            newchild.ParentId = child.ParentId;
            newchild.DateBorn = child.DateBorn;
            newchild.FamilyName = child.FamilyName;
            return newchild;
        }
    }
}
