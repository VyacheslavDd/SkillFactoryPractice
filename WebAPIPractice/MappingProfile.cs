using AutoMapper;
using WebAPIPractice.Contracts;
using WebAPIPractice.Contracts.Devices;
using WebAPIPractice.Contracts.Rooms;
using WebAPIPractice.Models;

namespace WebAPIPractice
{
    public class MappingProfile : Profile
    {
        public MappingProfile() 
        {
            CreateMap<Address, AddressInfo>();
            CreateMap<HomeOptions, InfoResponse>().ForMember(m => m.AddressInfo, opt => opt.MapFrom(src => src.Address));
            CreateMap<AddDeviceRequest, Device>()
                .ForMember(d => d.Location,
                    opt => opt.MapFrom(r => r.Location));
            CreateMap<AddRoomRequest, Room>();
            CreateMap<Room, RoomView>();
            CreateMap<Device, DeviceView>();
        }
    }
}
