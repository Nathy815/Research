using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Itau.Research.Domain.Models
{
    public class TrackPresence : Base
    {
        public bool IsConfirmed { get; set; }
        public bool IsPresent { get; set; }

        [ForeignKey("UserID")]
        public Guid UserID { get; set; }
        public virtual User Usuario { get; set; }

        [ForeignKey("TrackID")]
        public Guid TrackID { get; set; }
        public virtual Track Track { get; set; }
    }
}
