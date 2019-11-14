using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Itau.Research.Domain.Models
{
    public class Track : Base
    {
        public DateTime InitialDate { get; set; }
        public DateTime FinalDate { get; set; }
        public string Name { get; set; }
        public virtual ICollection<TrackPresence> TrackPresences { get; set; }

        [ForeignKey("EventID")]
        public Guid EventID { get; set; }
        public virtual Event Evento { get; set; }
    }
}
