﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SkyTravel.Core.Entities
{
    public class BaseEntity
    {
        public virtual int Id { get; set; }
        public bool state { get; set; }
    }
}