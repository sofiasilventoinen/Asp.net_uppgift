using ASP.Net_Inlamningsuppgift.Contexts;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System.Security.Claims;

namespace ASP.Net_Inlamningsuppgift.Models.Identity
{
    public class AppUserClaims : UserClaimsPrincipalFactory<IdentityUser, IdentityRole>
    {
        private readonly IdentityContext _context;

        public AppUserClaims(UserManager<IdentityUser> userManager, RoleManager<IdentityRole> roleManager, IOptions<IdentityOptions> options, IdentityContext context) : base(userManager, roleManager, options)
        {
            _context = context;
        }

        protected override async Task<ClaimsIdentity> GenerateClaimsAsync(IdentityUser user)
        {
            var claimsIdentity = await base.GenerateClaimsAsync(user);
            var userProfile = await _context.UserProfiles.FirstOrDefaultAsync(x => x.UserId == user.Id);
            claimsIdentity.AddClaim(new Claim("userid", user.Id ?? ""));
            return claimsIdentity;
        }
    }
}
