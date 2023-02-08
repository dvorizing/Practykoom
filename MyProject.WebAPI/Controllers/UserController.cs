using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyProject.Common.DTO;
using MyProject.Services.Interfaces;
using MyProject.WebAPI.models;

namespace MyProject.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        public async Task<List<UserDTO>> GetAllUser()
        {
            return await _userService.GetAllAsync();
        }
        [HttpGet("{id}")]
        public async Task<UserDTO> GetUserById(string id)
        {
            return await _userService.GetByIdAsync(id);
        }
        [HttpDelete("{id}")]
        public async Task DeleteUser(string id)
        {
            await _userService.DeleteAsync(id);
        }
        [HttpPut("{id}")]
        public async Task<UserDTO> PutUser(int id, [FromBody] UserModel userModel)
        {
            return await _userService.UpdateAsync(new UserDTO
            {
                Id = userModel.Id,
                Name = userModel.Name,
                FamilyName = userModel.FamilyName,
                Gender = (Common.DTO.EGenderD)userModel.Gender,
                MedicalClinic = (Common.DTO.EMedicalClinicD)userModel.MedicalClinic,
                DateBorn = userModel.DateBorn
            });
        }
        [HttpPost]
        public async Task<UserDTO> PostUser([FromBody] UserModel userModel)
        {
            return await _userService.AddAsync(new UserDTO()
            {
                Id = userModel.Id,
                Name = userModel.Name,
                FamilyName = userModel.FamilyName,
                Gender = (Common.DTO.EGenderD)userModel.Gender,
                MedicalClinic = (Common.DTO.EMedicalClinicD)userModel.MedicalClinic,
                DateBorn = userModel.DateBorn
            });
        }
    }
}
