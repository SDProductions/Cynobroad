using Microsoft.AspNetCore.Identity;

namespace Continuum.Areas.Identity.Data
{
    public class ContinuumUser : IdentityUser
    {
        public string Differentiator { get; set; }
    }
}
