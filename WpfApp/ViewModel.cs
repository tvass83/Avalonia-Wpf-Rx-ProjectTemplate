using ReactiveUI;
using ReactiveUI.Fody.Helpers;
using System;
using System.Diagnostics;
using System.Reactive;
using System.Reactive.Concurrency;
using System.Reactive.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace WpfApp
{
    public class ViewModel : ReactiveObject
    {
        public ViewModel()
        {
            TestCommand = ReactiveCommand.Create(OnTest);
        }

        public ReactiveCommandBase<Unit, Unit> TestCommand { get; }

        private void OnTest()
        {
            var b = RxApp.MainThreadScheduler;
        }
    }
}
