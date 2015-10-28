﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFirstApp.Context
{
    public interface IContextFactory<T> where T: class, IDbContext
    {
        T GetContext();
    }
}