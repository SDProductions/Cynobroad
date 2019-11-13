using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Continuum.Models
{
    public class Message
    {
        public int Id { get; set; }

        public string OwnerID { get; set; }
        public DateTime Date { get; set; }
        public string Content { get; set; }
    }
}
