using AdzukiMe.PolygonReducer.Domain;
using UnityEngine;

namespace AdzukiMe.PolygonReducer.Infrastructure
{
    internal sealed class MeshRepositorySMR
        : IMeshRepository
    {
        private readonly SkinnedMeshRenderer _skinnedMeshRenderer;

        public MeshRepositorySMR
            (SkinnedMeshRenderer skinnedMeshRenderer)
        {
            _skinnedMeshRenderer = skinnedMeshRenderer;
        }

        public Mesh Value
        {
            get => _skinnedMeshRenderer.sharedMesh;
            set => _skinnedMeshRenderer.sharedMesh = value;
        }
    }
}
