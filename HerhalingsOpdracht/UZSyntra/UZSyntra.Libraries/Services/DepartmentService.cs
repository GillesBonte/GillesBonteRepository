using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UZSyntra.Data.Models;
using UZSyntra.Libraries.Repositories;
using UZSyntra.Libraries.Interfaces;
using UZSyntra.Libraries.ViewModels;
using AutoMapper;
using UZSyntra.Libraries.Profiles;

namespace UZSyntra.Libraries.Services
{
    public class DepartmentService
    {
        private IRepository<Department> _depRepo;
        private IMapper _mapper;
        public DepartmentService(IRepository<Department> depRepo, IMapper mapper)
        {
            _depRepo = depRepo;
            _mapper = mapper;
        }

        public IEnumerable<DepartmentViewModel> GetAll()
        {
            return _mapper.Map<List<DepartmentViewModel>>
                (_depRepo.GetAll().ToList());
        }

        public DepartmentViewModel GetById(int id)
        {
            return _mapper.Map<DepartmentViewModel>(_depRepo.GetById(id));
        }
        public void Add(DepartmentViewModel department)
        {
            _depRepo.Add(_mapper.Map<Department>(department));

        }
        public void Update(DepartmentViewModel department)
        {
            _depRepo.Update(_mapper.Map<Department>(department));
        }
        public void Delete(int id)
        {
            _depRepo.Delete(id);
        }
    }
}
