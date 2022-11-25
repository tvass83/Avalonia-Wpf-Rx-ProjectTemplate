using Avalonia.Threading;
using ReactiveUI;
using ReactiveUI.Fody.Helpers;
using System;
using System.Reactive;
using System.Reactive.Concurrency;
using System.Reactive.Linq;

namespace AvaloniaApp
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
            var a = AvaloniaScheduler.Instance;
            var b = RxApp.MainThreadScheduler;
        }
    }
}
