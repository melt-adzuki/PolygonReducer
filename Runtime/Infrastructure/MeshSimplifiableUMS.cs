using AdzukiMe.PolygonReducer.Domain;
using UnityEngine;
using UnityMeshSimplifier;

namespace AdzukiMe.PolygonReducer.Infrastructure
{
    internal sealed class MeshSimplifiableUMS : IMeshSimplifiable
    {
        public Mesh Mesh { private get; init; }
        
        public Mesh GetSimplified(float quality)
        {
            var meshSimplifier = new MeshSimplifier(Mesh);
            meshSimplifier.SimplifyMesh(quality);
            
            return GetProcessedMesh(meshSimplifier);
        }

        public Mesh GetSimplifiedLossless()
        {
            var meshSimplifier = new MeshSimplifier(Mesh);
            meshSimplifier.SimplifyMeshLossless();
            
            return GetProcessedMesh(meshSimplifier);
        }

        private Mesh GetProcessedMesh(MeshSimplifier meshSimplifier)
        {
            var mesh = meshSimplifier.ToMesh();
            mesh.name = $"{Mesh.name} (Simplified)";
            
            return mesh;
        }
    }
}
