using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UZSyntra.Data.Models;
using UZSyntra.Libraries.Interfaces;
using UZSyntra.Libraries.ViewModels;

namespace UZSyntra.Libraries.Services
{
    public class RoomService
    {
        private IRepository<Room> _roomRepo;
        private IMapper _mapper;

        public RoomService(IRepository<Room> roomRepo, IMapper mapper)
        {
            _roomRepo = roomRepo;
            _mapper = mapper;
        }

        public IEnumerable<RoomViewModel> GetAll()
        {
            return _mapper.Map<List<RoomViewModel>>
                (_roomRepo.GetAll().ToList());
        }

        public RoomViewModel GetById(int id)
        {
            return _mapper.Map<RoomViewModel>(_roomRepo.GetById(id));
        }
        public void Add(RoomViewModel room)
        {
            _roomRepo.Add(_mapper.Map<Room>(room));

        }
        public void Update(RoomViewModel room)
        {
            _roomRepo.Update(_mapper.Map<Room>(room));
        }
        public void Delete(int id)
        {
            _roomRepo.Delete(id);
        }




    }
}
