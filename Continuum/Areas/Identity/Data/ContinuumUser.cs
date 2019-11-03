using Microsoft.AspNetCore.Identity;

namespace Continuum.Areas.Identity.Data
{
    public class ContinuumUser : IdentityUser
    {
        public int Differentiator { get; set; }
    }
}
