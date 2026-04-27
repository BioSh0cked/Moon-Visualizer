using n1 = global::System;
using n2 = global::_AudioReactiveVisualizer_.Main;
internal sealed class Program
{
    [n1.STAThread]
    public static void Main(){
        using (var appHost = new VL.App.WindowsForms.WindowsFormsAppHost(c => n2.AudioReactiveVisualizerApplication_P.Create(c), s => ((n2.AudioReactiveVisualizerApplication_P)s).Update())
        {
            UseHighPrecisionTimer = true,
            IgnoreUnhandledExceptions = false,
        }
        )
        {
            appHost.Run();
        }
    }
}
