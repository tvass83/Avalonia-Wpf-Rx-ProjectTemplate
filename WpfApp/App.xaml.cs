using ReactiveUI;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Reactive.Concurrency;
using System.Windows;

namespace WpfApp
{
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            RxApp.MainThreadScheduler = DispatcherScheduler.Current;

            base.OnStartup(e);
        }
    }
}
