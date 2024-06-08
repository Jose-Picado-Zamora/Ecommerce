﻿using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Emails
{
    public interface IEmailSender
    {
        public void SendEmail(Bill bill);
    }
}
