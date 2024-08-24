﻿//using Phase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarwarsHunters.Models
{
    public class Hunter
    {
        public string Name { get; set; }
        public string Story { get; set; }
        public string Image { get; set; }
        public List<string> Skills { get; set; }
    }
}
