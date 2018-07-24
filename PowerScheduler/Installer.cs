using System.ComponentModel;
using System.ServiceProcess;

namespace PowerScheduler
{
    [RunInstaller(true)]
    public class Installer : System.Configuration.Install.Installer
    {

        private ServiceProcessInstaller
            serviceProcessInstaller1;

        private ServiceInstaller serviceInstaller1;

        /// <summary> 
        /// Required designer variable. 
        /// </summary>
        private System.ComponentModel.Container components = null;

        public Installer()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            serviceProcessInstaller1 =
                new ServiceProcessInstaller();
            serviceInstaller1 =
                new ServiceInstaller();

            serviceProcessInstaller1.Account =
                ServiceAccount.LocalSystem;
            serviceProcessInstaller1.Password = null;
            serviceProcessInstaller1.Username = null;

            serviceInstaller1.ServiceName = "PowerScheduler";
            serviceInstaller1.DisplayName = "PowerScheduler";
            serviceInstaller1.StartType =
                ServiceStartMode.Automatic;

            Installers.AddRange
            (new System.Configuration.Install.Installer[]
            {
                serviceProcessInstaller1,
                serviceInstaller1
            });
        }
    }
}