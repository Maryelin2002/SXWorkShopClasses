﻿using AutoMapper;
using GenericApi.Core.BaseModel;
using GenericApi.Model.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericApi.Services.Services
{
    public interface IBaseService<TEntity, TDto>
    {
        Task<IEnumerable<TDto>> GetAllAsync();
        Task<TDto> GetByIdAsync(int id);
        Task<TDto> AddAsync(TDto dto);
        Task<TDto> UpdateAsync(int id, TDto dto);
        Task<TDto> DeleteByIdAsync(int id);
    }
    public class BaseService<TEntity, TDto> : IBaseService<TEntity, TDto>
        where TEntity : class, IBase
        where TDto : class, IBaseDto
    {
        protected readonly IMapper _mapper;
        protected readonly IBaseRepository<TEntity> _repository;
        public BaseService(IBaseRepository<TEntity> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public async Task<IEnumerable<TDto>> GetAllAsync()
        {
            var result = await _repository.Query().ToListAsync();
            var dtos = _mapper.Map<IEnumerable<TDto>>(result);
            return dtos;
        }
        public async Task<TDto> GetByIdAsync(int id)
        {
            var entity = await _repository.Get(id);
            var dto = _mapper.Map<TDto>(entity);
            return dto;
        }
        public async Task<TDto> AddAsync(TDto dto)
        {
            TEntity entity = _mapper.Map<TEntity>(dto);
            var result = await _repository.Add(entity);
            _mapper.Map(result, dto);

            return dto;
        }

        public async Task<TDto> UpdateAsync(int id, TDto dto)
        {
            var entity = await _repository.Get(id);
            _mapper.Map(dto, entity);

            var result = await _repository.Update(entity);
            _mapper.Map(result, dto);
            return dto;
        }

        public async Task<TDto> DeleteByIdAsync(int id)
        {
            var entity = await _repository.Delete(id);
            var dto = _mapper.Map<TDto>(entity);
            return dto;
        }
    }
}