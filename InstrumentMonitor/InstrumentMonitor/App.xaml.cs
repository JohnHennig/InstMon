using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Windows;

namespace InstrumentMonitor
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            Window window = Start(() => base.OnStartup(e));
            window.Show();
        }

        public static Window Start(Action baseStartup)
        {
            InstrumentMonitorView instMonView = new InstrumentMonitorView();
            InstrumentMonitorViewModel instMonViewModel = new InstrumentMonitorViewModel();

            instMonView.DataContext = instMonViewModel;

            return instMonView;
        }
    }
}
