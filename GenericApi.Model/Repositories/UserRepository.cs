using GenericApi.Model.Contexts;
using GenericApi.Model.Entities;

namespace GenericApi.Model.Repositories
{
    public interface IUserRepository : IBaseRepository<User> { }
    public class UserRepository : BaseRepository<User>, IUserRepository
    {
        public UserRepository(WorkShopContext context) : base(context)
        {

        }
    }
}
