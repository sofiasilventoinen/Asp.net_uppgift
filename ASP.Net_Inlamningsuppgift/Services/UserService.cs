using ASP.Net_Inlamningsuppgift.Contexts;
using ASP.Net_Inlamningsuppgift.Models.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Metadata.Ecma335;

namespace ASP.Net_Inlamningsuppgift.Services
{
    public class UserService
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly IdentityContext _context;

        public UserService(UserManager<IdentityUser> userManager, IdentityContext context)
        {
            _userManager = userManager;
            _context = context;
        }

        public async Task<UserAccount> GetUserAccountAsync (string id)
        {
            var identityUser = await _userManager.Users.FirstOrDefaultAsync(x => x.Id == id);
            if (identityUser != null) 
            {
                var identityProfile = await _context.UserProfiles.FirstOrDefaultAsync(x => x.UserId == identityUser.Id);
            
                if (identityProfile != null) 
                {
                    return new UserAccount
                    {
                        Id = identityUser.Id,
                        FirstName = identityProfile.FirstName,
                        LastName = identityProfile.LastName,
                        Email = identityUser.Email!,
                        PhoneNumber = identityUser.PhoneNumber,
                        StreetName = identityProfile.StreetName,
                        PostalCode = identityProfile.PostalCode,
                        Company = identityProfile.Company
                    };
                }
            }
           
            return null!;
        }
        

       /* public async Task<IdentityUser> GetUserAsync(Func<IdentityUser, bool > predicate)
        {
            var user = await _userManager.Users.FirstOrDefaultAsync(predicate);
        }*/
    }
}
