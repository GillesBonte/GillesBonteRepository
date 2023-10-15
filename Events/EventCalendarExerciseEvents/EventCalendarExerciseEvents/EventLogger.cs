using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventCalendarExerciseEvents
{
    public class EventLogger
    {
        //private EventCalendar _events = new EventCalendar();

        public EventCalendar EventCalendar { get; set; }

        public EventLogger(EventCalendar eCalendar)
        {
            EventCalendar = eCalendar;
            EventCalendar.EventRemoved += _events_EventRemoved;
            EventCalendar.EventAdded += _events_EventAdded;
        }

        private void _events_EventRemoved(object sender, EventEventArgs e)
        {
            MessageBox.Show($"{e} has been removed");
        }

        private void _events_EventAdded(object sender, EventEventArgs e)
        {
            MessageBox.Show($"{e} has been added");
        }
    }
}
