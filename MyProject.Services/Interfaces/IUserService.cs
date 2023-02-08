using MyProject.Common.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Services.Interfaces
{
    public interface IUserService
    {

        Task<List<UserDTO>> GetAllAsync();

        Task<UserDTO> GetByIdAsync(string id);

        Task<UserDTO> AddAsync(UserDTO User);

        Task<UserDTO> UpdateAsync(UserDTO User);

        Task DeleteAsync(string id);
    
      
    }
}
