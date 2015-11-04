﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFirstApp.IContext
{
    public interface IDataContext : IDisposable
    {
        int SaveChanges();
    }
}
