using AdzukiMe.PolygonReducer.Editor;
using AdzukiMe.PolygonReducer.Editor.Passes;
using nadena.dev.ndmf;

[assembly: ExportsPlugin(typeof(PolygonReducerPlugin))]

namespace AdzukiMe.PolygonReducer.Editor
{
    internal sealed class PolygonReducerPlugin : Plugin<PolygonReducerPlugin>
    {
        public override string DisplayName => "Polygon Reducer";
        
        protected override void Configure()
        {
            InPhase(BuildPhase.Transforming)
                .BeforePlugin("com.anatawa12.avatar-optimizer")
                .Run(ReduceSkinnedMeshPass.Instance);
        }
    }
}
