using Itau.Research.Domain.Interfaces;
using Itau.Research.Domain.Models;
using Itau.Research.Infra.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Itau.Research.Infra.Repositories
{
    public class ScoreRepository : Repository<Score>, IScore
    {
        public ScoreRepository(SqlContext context) : base(context)
        {

        }
    }
}
