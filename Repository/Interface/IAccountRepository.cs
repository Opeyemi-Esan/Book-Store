using BookStore.Model;
using Microsoft.AspNetCore.Identity;

namespace BookStore.Repository.Interface
{
    public interface IAccountRepository
    {
        Task<IdentityResult> SignUpAsync(SignUpModel signUpModel);
        Task<string> LoginAsync(SignInModel signInModel);
    }
}
