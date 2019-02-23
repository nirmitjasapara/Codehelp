using System.Linq;
using AutoMapper;
using CodehelpApp.API.Dtos;
using CodehelpApp.API.Models;

namespace CodehelpApp.API.Helpers
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<Question, QuestionForListDto>();
            CreateMap<Question, QuestionForDetailedDto>();
        }
    }
}