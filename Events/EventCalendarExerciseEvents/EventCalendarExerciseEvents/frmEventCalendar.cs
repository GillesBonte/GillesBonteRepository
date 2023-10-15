namespace EventCalendarExerciseEvents
{
    public partial class frmEventCalendar : Form
    {
        public frmEventCalendar()
        {
            InitializeComponent();
        }

        private void frmEventCalendar_Load(object sender, EventArgs e)
        {
            Event eNieuwEvent = new Event() {Name = "TestEvent", Date = DateTime.Now };
            EventCalendar eventCalendar = new EventCalendar();
            EventLogger eLog = new EventLogger(eventCalendar);

            //EventCalendar.Add(eNieuwEvent);
            eventCalendar.Add(eNieuwEvent);
        }
    }
}