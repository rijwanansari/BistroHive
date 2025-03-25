using Microsoft.AspNetCore.Identity;

namespace IdentityService.Infrastructure.Identity;

public class ApplicationUser : IdentityUser
{
    public string FullName { get; set; } = string.Empty;

}
