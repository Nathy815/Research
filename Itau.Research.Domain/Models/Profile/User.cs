using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Itau.Research.Domain.Models
{
    public class User : Base
    {
        public string Name { get; set; }
        public string Cellphone { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Occupation { get; set; }
        public string ImagePath { get; set; }

        [DefaultValue(false)]
        public bool IsPassVerified { get; set; }

        public virtual ICollection<Interest> Interesses { get; set; }
        public virtual ICollection<TrackPresence> TracksPresence { get; set; }
        public virtual ICollection<Score> Scores { get; set; }

        [ForeignKey("TierID")]
        public Guid TierID { get; set; }
        public virtual Tier Tier { get; set; }
    }
}
