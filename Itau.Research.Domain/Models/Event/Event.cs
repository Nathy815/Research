using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Itau.Research.Domain.Models
{
    public class Event : Base
    {
        public DateTime InitialDate { get; set; }
        public DateTime FinalDate { get; set; }
        public DateTime CreationDate { get; set; }
        public string Title { get; set; }
        public string Sector { get; set; }
        public string LocalName { get; set; }
        public string Address { get; set; }
        public string Content { get; set; }
        public virtual ICollection<Track> Tracks { get; set; }
        public virtual ICollection<Segment> Segmentos { get; set; }

        [ForeignKey("TierID")]
        public Guid TierID { get; set; }
        public virtual Tier Tier { get; set; }

        [ForeignKey("CategoryID")]
        public Guid CategoryID { get; set; }
        public virtual Category Categoria { get; set; }
    }
}
