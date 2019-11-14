using System;
using System.Collections.Generic;
using System.Text;

namespace Itau.Research.Application.ViewModels
{
    public class SegmentVM
    {
        public Guid guid { get; set; }
        public string name { get; set; }
        public string imagePath { get; set; }
        public bool active { get; set; }
    }
}
