using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyProject.Common.DTO;
using MyProject.Services.Interfaces;
using MyProject.WebAPI.models;

namespace MyProject.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChildController : ControllerBase
    {

        private readonly IChildService _childService;
        public ChildController(IChildService childService)
        {
            _childService = childService;
        }

        [HttpGet]
        public async Task<List<ChildDTO>> GetAllChild()
        {
            return await _childService.GetAllAsync();
        }
        [HttpGet("{id}")]
        public async Task<ChildDTO> GetChildById(string id)
        {
            return await _childService.GetByIdAsync(id);
        }
        [HttpDelete("{id}")]
        public async Task DeleteChild(string id)
        {
            await _childService.DeleteAsync(id);
        }
        [HttpPut("{id}")]
        public async Task<ChildDTO> PutChild(int id, [FromBody] ChildModel childModel)
        {
            return await _childService.UpdateAsync(new ChildDTO
            {
                Id = childModel.Id,
                FamilyName = childModel.FamilyName,
                DateBorn = childModel.DateBorn
            });
        }
        [HttpPost]
        public async Task<ChildDTO> PostChild([FromBody] ChildModel childModell)
        {
            return await _childService.AddAsync(new ChildDTO
            {
                Id = childModell.Id,
                FamilyName = childModell.FamilyName,
                DateBorn = childModell.DateBorn,
                ParentId= childModell.ParentId
                
            });
        }
    }
}