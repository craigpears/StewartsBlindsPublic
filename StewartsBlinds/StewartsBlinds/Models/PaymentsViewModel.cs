﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StewartsBlinds.Data.Entities;

namespace StewartsBlinds.Models
{
    public class PaymentsViewModel
    {
        public List<Payment> Payments { get; internal set; }
    }
}
