using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using UZSyntra.Data.Models;
using UZSyntra.Libraries.ViewModels;

namespace UZSyntra.Libraries.Profiles
{
    public class AutomapperProfiles : Profile
    {
        public AutomapperProfiles()
        {
            CreateMap<Department, DepartmentViewModel>();
            CreateMap<DepartmentViewModel, Department>();
            CreateMap<Room, RoomViewModel>();
            CreateMap<RoomViewModel, Room>();

        }
    }
}
