using AutoMapper;
using GenericApi.Bl.Dto;
using GenericApi.Model.Entities;


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
