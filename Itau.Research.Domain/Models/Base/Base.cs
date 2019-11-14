using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Itau.Research.Domain.Models
{
    public class Base
    {
        [Key]
        public Guid Id { get; set; }

        [DefaultValue(true)]
        public bool Active { get; set; }
    }
}
