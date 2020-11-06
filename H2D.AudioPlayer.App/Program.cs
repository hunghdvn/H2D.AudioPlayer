using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace H2D.AudioPlayer.App
{
    static class Program
    {
        public static Main form;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            var lstFile = new List<string>();
            if (args != null && args.Length > 0)
            {
                lstFile = args.ToList();
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            form = new Main(lstFile);
            SingleInstanceAppStarter.Start(form, StartNewInstance);
        }

        private static void StartNewInstance(object sender, StartupNextInstanceEventArgs e)
        {
            if (e.CommandLine.Count > 1)
            {
                String cmdArg = e.CommandLine[1];
                form.AddNewTrack(cmdArg);
            }
        }
    }

    class SingleInstanceAppStarter
    {
        static SingleInstanceApp app = null;

        public static void Start(Form f, StartupNextInstanceEventHandler handler)
        {
            if (app == null && f != null)
            {
                app = new SingleInstanceApp(f);
            }
            app.StartupNextInstance += handler;
            app.Run(Environment.GetCommandLineArgs());
        }
    }

    class SingleInstanceApp : WindowsFormsApplicationBase
    {
        public SingleInstanceApp() { }

        public SingleInstanceApp(Form f)
        {
            base.IsSingleInstance = true;
            this.MainForm = f;
        }
    }
}
