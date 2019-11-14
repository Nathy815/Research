using System;
using System.Collections.Generic;
using System.Text;

namespace Itau.Research.Domain.Models
{
    public class Tier : Base
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImagePath { get; set; }
        public virtual ICollection<Event> Eventos { get; set; }
        public virtual ICollection<User> Usuarios { get; set; }
        public virtual ICollection<Report> Reports { get; set; }
    }
}
