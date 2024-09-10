using AdzukiMe.PolygonReducer.Infrastructure;
using UnityEngine;

namespace AdzukiMe.PolygonReducer.Components
{
    [AddComponentMenu("Polygon Reducer/PR Reduce SkinnedMesh")]
    [RequireComponent(typeof(SkinnedMeshRenderer))]
    [DisallowMultipleComponent]
    internal sealed class ReduceSkinnedMeshComponent : ReducerComponent
    {
        protected override void SetMeshFromComponent()
        {
            Mesh = new MeshRepositorySMR(GetComponent<SkinnedMeshRenderer>());
        }
    }
}
