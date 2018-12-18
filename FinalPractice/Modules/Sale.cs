﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalPractice
{
    class Sale
    {
        public int SalespersonKey { get; set; }
        public int WWInvoice { get; set; }
        public string Description { get; set; }
        public float Total { get; set; }

        public string Getinfo
        {
            get
            {
                return $"{SalespersonKey } { WWInvoice } { Description } { Total}";
            }
        }
    }
}
