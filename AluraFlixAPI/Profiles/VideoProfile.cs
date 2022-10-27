using AluraFlixAPI.Models;
using AutoMapper;

namespace AluraFlixAPI.Profiles
{
    public class VideoProfile : Profile
    {
        public VideoProfile()
        {
            CreateMap<VideoUpdate, Video>();
        }
    }
}
