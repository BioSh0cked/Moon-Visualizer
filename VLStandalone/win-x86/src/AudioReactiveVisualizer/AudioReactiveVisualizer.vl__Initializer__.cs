extern alias e212;
extern alias e227;
extern alias e1;
extern alias e2;
extern alias e204;
using n2 = e2::VL.Core;
using n11 = e227::_VL_Audio_;
using n10 = e212::_VL_Skia_;
using n1 = e2::VL.Core.CompilerServices;
using n8 = e2::VL.AppServices.CompilerServices;
using n4 = e1::VL.Core.CompilerServices;
using n3 = global::_AudioReactiveVisualizer_;
using n7 = global::_AudioReactiveVisualizer_.Main;
using n5 = e1::VL.Core;
using n9 = e204::_VL_CoreLib_;
using n6 = e2::VL.Model;
[assembly: n1.CompilerVersion(@"2025.7.1")]
[assembly: n1.SymbolSourceReference(@"VL.CoreLib.vl", n2.SymbolSourceKind.Document, false, false)]
[assembly: n1.SymbolSourceReference(@"VL.Skia.vl", n2.SymbolSourceKind.Document, false, false)]
[assembly: n1.SymbolSourceReference(@"VL.Audio.vl", n2.SymbolSourceKind.Document, false, false)]
[assembly: n4.AssemblyInitializer(typeof(n3.RckyMa2RP3mPQ0ttObPClAInitializer))]
[assembly: n1.TypeImport(@"RckyMa2RP3mPQ0ttObPClA", @"GJ1qVhe2U8iQcErgM02WAO", @"AudioReactiveVisualizerApplication", @"Main", n5.SymbolSmell.Hidden, n6.KnownTypeStructure.None, typeof(n7.AudioReactiveVisualizerApplication_P), null, n8.Mutability.Auto, true)]
[assembly: n1.Process(@"Application", @"", n5.SymbolSmell.Hidden, typeof(n7.AudioReactiveVisualizerApplication_P), false, [@"Create", @"Update"], [@"Update"])]
[assembly: n8.AdaptiveImplementations(typeof(n3.__AdaptiveImplementations__RckyMa2RP3mPQ0ttObPClA))]
namespace _AudioReactiveVisualizer_
{
    public sealed class RckyMa2RP3mPQ0ttObPClAInitializer : n1.PatchedAssemblyInitializer<n3.RckyMa2RP3mPQ0ttObPClAInitializer>
    {
        public override sealed void CollectDependencies(n4.DependencyCollector collector){
            collector.AddDependency(n9.LMFQrbYrtQvO4pn4vSywS3Initializer.Default);
            collector.AddDependency(n10.M1XXME8bUtmNxzMxVHhNawInitializer.Default);
            collector.AddDependency(n11.HTX4axw4uH5NDghqAqpe1FInitializer.Default);
            base.CollectDependencies(collector);
        }
        public override sealed void Configure(n5.AppHost appHost){
            base.Configure(appHost);
        }
    }
}
