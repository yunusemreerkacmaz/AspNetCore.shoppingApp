using ShoppingApp.Core.DataAccess;
using ShoppingApp.MsSqlServer.Entities.Concrete;

namespace ShoppingApp.MsSqlServer.DataAccess.Abstract
{
    public interface ICategoryDal : IEntityRepository<Category>
    {
        // Custom Operations
    }
}
