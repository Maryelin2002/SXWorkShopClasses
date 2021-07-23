using AutoMapper;
using FluentValidation;
using GenericApi.Bl.Dto;
using GenericApi.Model.Entities;
using GenericApi.Model.Repositories;

namespace GenericApi.Services.Services
{
    public interface IDocumentService : IBaseService<Document, DocumentDto> {}
    public class DocumentService : BaseService<Document, DocumentDto>, IDocumentService
    {
        public DocumentService(
            IDocumentRepository repository, 
            IMapper mapper,
            IValidator<DocumentDto> validator) : base(repository, mapper, validator)
        {
        }
    }
}
