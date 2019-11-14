using Itau.Research.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Itau.Research.Domain.Interfaces;
using Itau.Research.Infra.Data;

namespace Itau.Research.Infra.Repositories
{
    public class SegmentRepository : Repository<Segment>, ISegment
    {
        public SegmentRepository(SqlContext context) : base(context)
        {
        }
    }
}
