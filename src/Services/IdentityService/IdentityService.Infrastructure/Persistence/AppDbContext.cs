using IdentityService.Infrastructure.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace IdentityService.Infrastructure.Persistence;

public class AppDbContext : IdentityDbContext<ApplicationUser>
{

}
