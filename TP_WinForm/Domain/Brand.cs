﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Brand
    {
        public int ID { get; set; }
        public string Description { get; set; }
        public override string ToString()
        {
            return Description;
        }
    }
}
