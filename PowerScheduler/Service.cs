using System;
using System.Linq;
using System.ServiceProcess;
using System.Timers;

namespace PowerScheduler
{
    public partial class Service : ServiceBase
    {
        private static Guid _balancedGuid;
        public Service()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            try
            {
                var guidPlans = PowerHelpers.GetAll();
                _balancedGuid = guidPlans.FirstOrDefault(g => PowerHelpers.ReadFriendlyName(g) == "Balanced");

                Timer timScheduledTask = new Timer();
                timScheduledTask.Interval = 60 * 1000;
                timScheduledTask.Enabled = true;
                timScheduledTask.Elapsed += timScheduledTask_Elapsed;
            }
            catch
            {
                
            }
        }
   
        void timScheduledTask_Elapsed(object sender, ElapsedEventArgs e)
        {
            PowerHelpers.PowerSetActiveScheme(IntPtr.Zero, ref _balancedGuid);
        }

        protected override void OnStop()
        {
        }
        
        public void Start()
        {
            OnStart(null);
        }
    }
}
