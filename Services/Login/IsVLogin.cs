﻿using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Login
{
    public interface IsVLogin
    {
        public User UserVerify(string userName, string password);
    }
}
