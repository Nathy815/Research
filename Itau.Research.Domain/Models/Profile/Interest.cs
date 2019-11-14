using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Itau.Research.Domain.Models
{
    public class Interest : Base
    {
        [ForeignKey("UserID")]
        public Guid UserID { get; set; }
        public virtual User Usuario { get; set; }

        [ForeignKey("SegmentID")]
        public Guid SegmentID { get; set; }
        public virtual Segment Segmento { get; set; }
    }
}
