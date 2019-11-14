using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Itau.Research.Domain.Models
{
    public class EventSegment : Base
    {
        [ForeignKey("EventID")]
        public Guid EventID { get; set; }
        public virtual Event Evento { get; set; }

        [ForeignKey("SegmentID")]
        public Guid SegmentID { get; set; }
        public virtual Segment Segmento { get; set; }
    }
}
