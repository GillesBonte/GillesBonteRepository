﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIListener.Models
{
    public class APIModel
    {
        public string API {  get; set; }
        public string Description { get; set; }
        public string Auth {  get; set; }
        public bool HTTPS { get; set; }
        public string Cors { get; set; }
        public string Link { get; set; }
        public string Category { get; set; }
    }
}
