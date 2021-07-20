﻿using AutoMapper;
using GenericApi.Bl.Dto;
using GenericApi.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericApi.Bl.Mapper
{
    public class MainProfile : Profile
    {
        public MainProfile()
        {
            CreateMap<Document, DocumentDto>().ReverseMap();

            CreateMap<Member, MemberDto>()
                .ForMember(dto => dto.PhotoFileName, config => config.MapFrom(entity => entity.Photo.FileName));

            CreateMap<MemberDto, Member>();
            CreateMap<WorkShop, WorkShopDto>().ReverseMap();
            CreateMap<WorkShopMember, WorkShopMemberDto>();
            CreateMap<WorkShopDay, WorkShopDayDto>();
        }
    }
}
