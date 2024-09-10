using AdzukiMe.PolygonReducer.Components;
using AdzukiMe.PolygonReducer.Infrastructure;
using AdzukiMe.PolygonReducer.Services;
using nadena.dev.ndmf;

namespace AdzukiMe.PolygonReducer.Editor.Passes
{
    internal class ReduceSkinnedMeshPass : Pass<ReduceSkinnedMeshPass>
    {
        protected override void Execute(BuildContext context)
        {
            foreach (var component in context.GetComponents<ReduceSkinnedMeshComponent>())
                ReduceSkinnedMeshService<MeshSimplifiableUMS>.Process(component);
        }
    }
}
