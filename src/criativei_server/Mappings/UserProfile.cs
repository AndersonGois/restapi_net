using AutoMapper;
using criativei_server.Model;

namespace criativei_server.Mappings
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<UserRequest, UserEntity>();
        }
    }
}
