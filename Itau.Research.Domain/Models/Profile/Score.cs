using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Itau.Research.Domain.Models
{
    public class Score : Base
    {
        public double Value { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }

        [ForeignKey("UserID")]
        public Guid UserID { get; set; }
        public virtual User Usuario { get; set; }
    }
}
