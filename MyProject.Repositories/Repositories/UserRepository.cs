using Microsoft.EntityFrameworkCore;
using MyProject.Repositories.Entities;
using MyProject.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Repositories.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly IContext _context;

        public UserRepository(IContext context)
        {
            _context = context;
        }

        public async Task<User> AddAsync(User user)
        {
            var newUser = new User();
            newUser.Id = user.Id;
            newUser.Name = user.Name;
            newUser.FamilyName = user.FamilyName;
            newUser.MedicalClinic = user.MedicalClinic;
            newUser.DateBorn = user.DateBorn;
            newUser.Gender = user.Gender;
            _context.Users.Add(newUser);
            await _context.SaveChangesAsync();
            return newUser;
        }

        public async Task DeleteAsync(string id)
        {
            _context.Users.Remove(await GetByIdAsync(id));
           await _context.SaveChangesAsync();
        }

        public async Task<List<User>> GetAllAsync()
        {
            return await _context.Users.ToListAsync();
        }

        public async Task<User> GetByIdAsync(string id)
        {
            return await _context.Users.FindAsync(id);
        }

        public async Task<User> UpdateAsync(User user)
        {
            User newuser = await GetByIdAsync(user.Id);
            newuser.Id = user.Id;
            newuser.MedicalClinic= user.MedicalClinic;  
            newuser.Gender= user.Gender;
            newuser.DateBorn = user.DateBorn;
            newuser.Name = user.Name;
            newuser.FamilyName = user.FamilyName;
            return newuser;
        }

        
    }
}
