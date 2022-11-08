﻿using Sample.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample.DataAccess.Repositories.Users
{
    public interface IUserRepository:IRepository<User,Guid>
    {
    }
}
