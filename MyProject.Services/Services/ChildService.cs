using AutoMapper;
using MyProject.Common.DTO;
using MyProject.Repositories.Entities;
using MyProject.Repositories.Interfaces;
using MyProject.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Services.Services
{
    public class ChildService : IChildService
    {
        private readonly IChildrenRepository _childrenRepository;
        private readonly IMapper _mapper;

        public ChildService(IChildrenRepository childrenRepository, IMapper mapper)
        {
            _childrenRepository = childrenRepository;
            _mapper = mapper;
        }

        public async Task<ChildDTO> AddAsync(ChildDTO child)
        {

            return _mapper.Map<ChildDTO>(await _childrenRepository.AddAsync(_mapper.Map<Child>(child)));
        }

        public async Task DeleteAsync(string id)
        {
            await _childrenRepository.DeleteAsync(id);
        }

        public async Task<List<ChildDTO>> GetAllAsync()
        {
            return _mapper.Map<List<ChildDTO>>(await _childrenRepository.GetAllAsync());
        }

        public async Task<ChildDTO> GetByIdAsync(string id)
        {
            return _mapper.Map<ChildDTO>(await _childrenRepository.GetByIdAsync(id));
        }

        public async Task<ChildDTO> UpdateAsync(ChildDTO child)
        {
            return _mapper.Map<ChildDTO>(await _childrenRepository.UpdateAsync(_mapper.Map<Child>(child)));
        }
    }
}
