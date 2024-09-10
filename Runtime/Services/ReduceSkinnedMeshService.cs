using AdzukiMe.PolygonReducer.Components;
using AdzukiMe.PolygonReducer.Domain;
using AdzukiMe.PolygonReducer.Infrastructure;
using UnityEngine;

namespace AdzukiMe.PolygonReducer.Services
{
    internal static class ReduceSkinnedMeshService<MeshSimplifiable>
        where MeshSimplifiable : IMeshSimplifiable, new()
    {
        public static void Process(ReduceSkinnedMeshComponent component)
        {
            var skinnedMeshRenderer = component.GetComponent<SkinnedMeshRenderer>();
            var repository = new MeshRepositorySMR(skinnedMeshRenderer);
            ReduceMeshService<MeshSimplifiable>.Process(mesh: repository, options: component);
        }
    }
}
