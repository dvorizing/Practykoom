using Microsoft.EntityFrameworkCore;
using MyProject.Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Repositories.Interfaces
{
    public interface IContext
    {
       public DbSet<User> Users { get; set; }
       public DbSet<Child> Children { get; set; }

       Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
   
    }
}
