using System;
using System.Threading.Tasks;
using xxAMIDOxx.xxSTACKSxx.Application.Integration;
using xxAMIDOxx.xxSTACKSxx.Domain;

namespace xxAMIDOxx.xxSTACKSxx.Infrastructure.Repositories
{
    public class DynamoDbMenuRepository : IMenuRepository
    {
        public DynamoDbMenuRepository()
        {
        }

        public Task<bool> DeleteAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<Menu> GetByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> SaveAsync(Menu entity)
        {
            throw new NotImplementedException();
        }
    }
}
