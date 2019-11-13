using Continuum.Areas.Identity.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Continuum.Models
{
    public class Server
    {
        public int Id { get; set; }

        public string OwnerID { get; set; }
        public List<ContinuumUser> Users { get; set; }
        public List<Message> Messages { get; set; }
    }
}
