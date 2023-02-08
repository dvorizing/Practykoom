using AutoMapper;
using MyProject.Common.DTO;
using MyProject.Repositories.Entities;
using MyProject.Repositories.Interfaces;
using MyProject.Repositories.Repositories;
using MyProject.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Services.Services
{

    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;

        public UserService(IUserRepository userRepository, IMapper mapper)
        {
            _userRepository = userRepository;
            _mapper = mapper;
        }

        public async Task<UserDTO> AddAsync(UserDTO User)
        {
            
            return _mapper.Map<UserDTO>(await _userRepository.AddAsync(_mapper.Map<User>(User)));
        }

        public async Task DeleteAsync(string id)
        {
             await _userRepository.DeleteAsync(id);
        }

        public async Task<List<UserDTO>> GetAllAsync()
        {
            return _mapper.Map<List< UserDTO>>(await _userRepository.GetAllAsync());
        }

        public async Task<UserDTO> GetByIdAsync(string id)
        {
            return _mapper.Map<UserDTO>(await _userRepository.GetByIdAsync(id));
        }

        public async Task<UserDTO> UpdateAsync(UserDTO User)
        {
            return _mapper.Map<UserDTO>(await _userRepository.UpdateAsync(_mapper.Map<User>(User)));
        }
       
    }
}
