﻿using GenericApi.Services.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BaseController<TEntity, TDto> : ControllerBase
    {
        protected readonly IBaseService<TEntity, TDto> _service;
        public BaseController(IBaseService<TEntity, TDto> service)
        {
            _service = service;
        }

        [HttpGet]
        public virtual async Task<IActionResult> Get()
        {
            var list = await _service.GetAllAsync();
            return Ok(list);
        }

        [HttpGet("{id}")]
        public virtual async Task<IActionResult> GetById([FromRoute] int id)
        {
            var result = await _service.GetByIdAsync(id);

            if (result is null) return NotFound();

            return Ok(result);
        }

        [HttpGet]
        public virtual async Task<IActionResult> Post([FromBody] TDto dto)
        {
            var result = await _service.AddAsync(dto);

            if (result.IsSuccess is false) return BadRequest(result);

            return Ok(result);
        }
    }
}
