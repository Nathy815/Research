using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Itau.Research.Domain.Models
{
    public class Report : Base
    {
        public string Title { get; set; }
        public string Subtitle { get; set; }
        public string Author { get; set; }
        public string Content { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime PublishDate { get; set; }
        public ICollection<Segment> Segmentos { get; set; }

        [ForeignKey("TierID")]
        public Guid TierID { get; set; }
        public virtual Tier Tier { get; set; }
    }
}
