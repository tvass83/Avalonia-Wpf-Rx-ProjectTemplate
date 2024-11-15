using Avalonia;
using Avalonia.ReactiveUI;

namespace Avalonia11App
{
    static class Program
    {
        // Initialization code. Don't use any Avalonia, third-party APIs or any
        // SynchronizationContext-reliant code before AppMain is called: things aren't initialized
        // yet and stuff might break.
        public static void Main(string[] args) => BuildAvaloniaApp()
            .StartWithClassicDesktopLifetime(args);

        // Avalonia configuration, don't remove; also used by visual designer.
        public static AppBuilder BuildAvaloniaApp()
           => AppBuilder.Configure<App>()
                .UsePlatformDetect() //or .UseWin32() // or UseAvaloniaNative() or UseX11()
              //.UseWin32()
              //.With(new Win32PlatformOptions()
              //{
              //    CompositionMode = new[] { Win32CompositionMode.LowLatencyDxgiSwapChain }
              //})
              //.UseDirect2D1() //or UseSkia()
                .UseReactiveUI()
                .LogToTrace();
    }
}
