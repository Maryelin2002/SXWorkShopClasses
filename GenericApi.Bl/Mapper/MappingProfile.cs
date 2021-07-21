using AutoMapper;
using GenericApi.Bl.Dto;
using GenericApi.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericApi.Bl.Mapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Document, DocumentDto>().ReverseMap();

            CreateMap<Member, MemberDto>()
                .ForMember(dto => dto.PhotoFileName, config => config.MapFrom(entity => entity.Photo.FileName));
            CreateMap<MemberDto, Member>();

            CreateMap<WorkShop, WorkShopDto>().ReverseMap();

            CreateMap<WorkShopMember, WorkShopMemberDto>().ReverseMap();

            CreateMap<WorkShopDay, WorkShopDayDto>().ReverseMap();
        }
    }
}
