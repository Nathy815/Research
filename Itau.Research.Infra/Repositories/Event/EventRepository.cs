using Itau.Research.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Itau.Research.Domain.Interfaces;
using Itau.Research.Infra.Data;

namespace Itau.Research.Infra.Repositories
{
    public class EventRepository : Repository<Event>, IEvent
    {
        public EventRepository(SqlContext context) : base(context)
        {
        }
    }
}
