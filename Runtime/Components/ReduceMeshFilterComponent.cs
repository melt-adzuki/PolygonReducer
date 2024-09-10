using UnityEngine;

namespace AdzukiMe.PolygonReducer.Components
{
    [AddComponentMenu("Polygon Reducer/PR Reduce MeshFilter")]
    [RequireComponent(typeof(MeshFilter))]
    [DisallowMultipleComponent]
    internal sealed class ReduceMeshFilterComponent : ReducerComponent
    {
        protected override void SetMeshFromComponent()
        {
            throw new System.NotImplementedException();
        }
    }
}
