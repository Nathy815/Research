using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Itau.Research.Domain.Models
{
    public class ReportSegment : Base
    {
        [ForeignKey("SegmentID")]
        public Guid SegmentID { get; set; }
        public virtual Segment Segmento { get; set; }

        [ForeignKey("ReportID")]
        public Guid ReportID { get; set; }
        public virtual Report Report { get; set; }
    }
}
