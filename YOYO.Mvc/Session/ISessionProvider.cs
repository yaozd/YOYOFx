﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YOYO.Owin;

namespace YOYO.Mvc.Session
{
    internal interface ISessionProvider
    {
        Task<ISession> AccessAsync(IOwinContext context);

    }
}
