﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusTracking.Core.Data;
using BusTracking.Core.DTO;

namespace BusTracking.Core.IService
{
    public interface ILoginService
    {
        Task<LoginResult> login(Login login);
    }
}
