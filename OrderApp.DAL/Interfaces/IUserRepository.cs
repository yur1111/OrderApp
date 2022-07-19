using OrderApp.D.Entities;
using System.Threading.Tasks;

namespace OrderApp.D.Interfaces
{
    public interface IUserRepository : IRepository<User>
    {
        Task<User> GetByUsername(string username);
        Task<User> GetByEmail(string email);
    }
}
