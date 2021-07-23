using GenericApi.Model.Contexts;
using GenericApi.Model.Entities;

namespace GenericApi.Model.Repositories
{
    public interface IDocumentRepository : IBaseRepository<Document> {}
    public class DocumentRepository : BaseRepository<Document>, IDocumentRepository
    {
        public DocumentRepository(WorkShopContext context) : base(context)
        {

        }
    }
}
