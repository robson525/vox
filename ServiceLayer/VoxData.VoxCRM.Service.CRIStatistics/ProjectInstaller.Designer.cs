namespace VoxData.VoxCRM.Service.CRIStatistics
{
    partial class ProjectInstaller
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.CRIStatistics = new System.ServiceProcess.ServiceProcessInstaller();
            this.serviceInstaller1 = new System.ServiceProcess.ServiceInstaller();
            // 
            // CRIStatistics
            // 
            this.CRIStatistics.Account = System.ServiceProcess.ServiceAccount.LocalSystem;
            this.CRIStatistics.Password = null;
            this.CRIStatistics.Username = null;
            // 
            // serviceInstaller1
            // 
            this.serviceInstaller1.Description = "Colect Service of ACD Statisctics";
            this.serviceInstaller1.DisplayName = "VoxData - CRM- CRIStatistics";
            this.serviceInstaller1.ServiceName = "VoxCRM-CRIStatistics";
            this.serviceInstaller1.StartType = System.ServiceProcess.ServiceStartMode.Automatic;
            // 
            // ProjectInstaller
            // 
            this.Installers.AddRange(new System.Configuration.Install.Installer[] {
            this.CRIStatistics,
            this.serviceInstaller1});

        }

        #endregion

        private System.ServiceProcess.ServiceProcessInstaller CRIStatistics;
        private System.ServiceProcess.ServiceInstaller serviceInstaller1;
    }
}