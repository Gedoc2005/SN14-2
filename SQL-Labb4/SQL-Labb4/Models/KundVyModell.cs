﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SQL_Labb4.Models
{
    public class KundVyModell
    {
        public int KundId { get; set; }
        public string ForNamn { get; set; }
        public string EfterNamn { get; set; }
        public string TelefonNr { get; set; }
        public string Email { get; set; }
        public int AntalLan { get; set; }

        public IList<KundBokModell> Boker { get; set; }
    }
}