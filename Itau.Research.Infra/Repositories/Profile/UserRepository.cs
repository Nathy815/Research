using Itau.Research.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Itau.Research.Domain.Interfaces;
using Itau.Research.Infra.Data;

namespace Itau.Research.Infra.Repositories
{
    public class UserRepository : Repository<User>, IUser
    {
        public UserRepository(SqlContext context) : base(context)
        {
        }
    }
}
