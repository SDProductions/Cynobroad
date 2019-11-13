using Continuum.Models;
using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace Continuum.Areas.Identity.Data
{
    public class ContinuumUser : IdentityUser
    {
        public string Differentiator { get; set; }

        public List<Server> Servers { get; set; }
    }
}
