﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventCalendarExerciseEvents
{
    public class Event
    {
        public string Name { get; set; }

        public DateTime Date { get; set; }

        public override string ToString()
        {
            return this.Name;
        }
    }

}
