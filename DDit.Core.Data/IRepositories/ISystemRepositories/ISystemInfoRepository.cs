﻿using DDit.Core.Data.SystemEntity.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDit.Core.Data.IRepositories
{
   public interface ISystemInfoRepository
    {
        SystemInfo GetSystemInfo();
    }
}
