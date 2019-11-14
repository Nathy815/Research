using Itau.Research.Domain.Interfaces;
using Itau.Research.Domain.Models;
using Itau.Research.Infra.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Itau.Research.Infra.Repositories
{
    public class InterestRepository : Repository<Interest>, IInterest
    {
        public InterestRepository(SqlContext context) : base(context)
        {
        }
    }
}
