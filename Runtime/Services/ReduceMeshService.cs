using AdzukiMe.PolygonReducer.Components;
using AdzukiMe.PolygonReducer.Domain;

namespace AdzukiMe.PolygonReducer.Services
{
    internal static class ReduceMeshService<MeshSimplifiable>
        where MeshSimplifiable : IMeshSimplifiable, new()
    {
        public static void Process(IMeshRepository mesh, ReducerComponent options)
        {
            var meshSimplifiable = new MeshSimplifiable
            {
                Mesh = mesh.Value
            };
            
            mesh.Value = options.isLossless
                ? meshSimplifiable.GetSimplifiedLossless()
                : meshSimplifiable.GetSimplified(options.quality);
        }
    }
}
