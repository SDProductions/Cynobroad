﻿using Continuum.Areas.Identity.Data;
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
        public string Name { get; set; }

        public List<User> Users { get; set; }
        public List<Message> Messages { get; set; }
    }
}
