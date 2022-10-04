using Webshop_Backend.Context;
using Webshop_Backend.DTO_s;

namespace Webshop_Backend.Container
{
    public class UserContainer
    {
        private readonly ApplicationDBContext _dbContext;

        public UserContainer(ApplicationDBContext dbContext)
        {
            _dbContext = dbContext;
        }

    }
}
