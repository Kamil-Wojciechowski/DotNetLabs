using System;
using System.Diagnostics;
using System.ServiceProcess;

namespace Zadanie03
{
    public partial class Zadanie03 : ServiceBase
    {

        private String source = "Zadanie03Source-1";
        private String log = "Event Source Log";
        private int eventId = 1;
        public Zadanie03()
        {
            InitializeComponent();
            eventLog1 = new System.Diagnostics.EventLog();
            if (!System.Diagnostics.EventLog.SourceExists(source))
            {
                System.Diagnostics.EventLog.CreateEventSource(source, log);
            }

            timer1.Start();

            eventLog1.Source = "Zadanie03Source";
            eventLog1.Log = log;

        }

        protected override void OnStart(string[] args)
        {
            eventLog1.WriteEntry("Service started");
        }

        protected override void OnStop()
        {
            timer1.Stop();
            eventLog1.WriteEntry("Service stopped");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            eventLog1.WriteEntry("Working", EventLogEntryType.Information, eventId++);
        }
    }
}
