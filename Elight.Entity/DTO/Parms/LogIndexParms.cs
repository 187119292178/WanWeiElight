﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elight.Entity.DTO.Parms
{
    public class LogIndexParms
    {
        public int pageIndex { get; set; }
        public int pageSize { get; set; }
        public string type { get; set; }
        public string index { get; set; }
        public string keyWord { get; set; }
    }
}