

using eCommerce.Core.DTO;
using eCommerce.Core.Entities;

namespace eCommerce.Core.ServiceContracts
{
    public interface IUsersService
    {
        Task <AuthenticationResponse?> Login(LoginRequest loginRequest);

        Task<AuthenticationResponse?> Register(RegisterRequest registerRequest);
        Task<UserDTO> GetUserByUserID(Guid userID);


    }
}
