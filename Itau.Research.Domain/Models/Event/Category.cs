using System;
using System.Collections.Generic;
using System.Text;

namespace Itau.Research.Domain.Models
{
    public class Category : Base
    {
        public string Name { get; set; }
        public virtual ICollection<Event> Eventos { get; set; }
    }
}
