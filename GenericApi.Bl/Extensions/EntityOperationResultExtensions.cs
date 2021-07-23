using FluentValidation.Results;
using GenericApi.Core.Abstract;
using System.Linq;

namespace GenericApi.Bl.Extensions
{
    public static class EntityOperationResultExtensions
    {
        public static IEntityOperationResult<TDto> ToOperationResult<TDto> (this TDto dto)
        {
            return new EntityOperationResult<TDto>(dto);
        }     
        
        
        public static IEntityOperationResult<TDto> ToOperationResult<TDto> (this ValidationResult validationResult)
        {
            return new EntityOperationResult<TDto>
            {
                Errors = validationResult.Errors.Select(x => x.ErrorMessage).ToList()
            };
        }
        
    }
}
