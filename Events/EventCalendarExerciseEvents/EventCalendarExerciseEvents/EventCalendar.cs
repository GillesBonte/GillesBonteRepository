using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventCalendarExerciseEvents
{
    public class EventCalendar
    {
        public delegate void EventAddedHandler(object sender, EventEventArgs e);
        public delegate void EventRemovedHandler(object sender, EventEventArgs e);
        //public static event EventAddedHandler EventAdded;
        //public static event EventRemovedHandler EventRemoved;
        public  event EventAddedHandler EventAdded;
        public  event EventRemovedHandler EventRemoved;
        private static List<Event> _events = new List<Event>();
        public EventCalendar()
        {

        }

        public void Add(Event e)
        {
            _events.Add(e);
            EventAdded?.Invoke(null, new EventEventArgs(e));

        }

        public void Remove(Event e)
        {
            _events.Remove(e);
            EventRemoved?.Invoke(null, new EventEventArgs(e));
        }

    }

}
