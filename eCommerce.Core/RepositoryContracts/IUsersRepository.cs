

using eCommerce.Core.Entities;

namespace eCommerce.Core.RepositoryContracts
{
    public interface IUsersRepository
    {
        Task<ApplicationUser?> AddUser(ApplicationUser user);
        Task<ApplicationUser?> GetUserByEmailAndPassword(string? email, string? password);
    }
}
