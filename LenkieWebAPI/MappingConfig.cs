using AutoMapper;
using LenkieWebAPI.Models;
using LenkieWebAPI.Models.DTO;

namespace LenkieWebAPI
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(config =>
            {
                config.CreateMap<BookDTO, Book>().ReverseMap();
            });

            return mappingConfig;
        }
    }
}
