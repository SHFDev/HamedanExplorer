﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Explorer.MVVM.Model
{
    public class Hotel_Model
    {
        public string Name { get; set; }
        public double Rating { get; set; }
        public string Star { get; set; }
        public string titelimage { get; set; }
        public string profimage { get; set; }
        public string about { get; set; }
        public string maploc { get; set; }
        public string Address { get; set; }
        public bool HasOffer { get; set; }
        public double Offering { get; set; }

    }
}
