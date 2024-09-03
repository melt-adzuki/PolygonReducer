using AdzukiMe.PolygonReducer.Components;
using nadena.dev.ndmf;
using UnityEngine;
using UnityMeshSimplifier;

namespace AdzukiMe.PolygonReducer.Editor.Passes
{
    internal class ReduceSkinnedMeshPass : Pass<ReduceSkinnedMeshPass>
    {
        protected override void Execute(BuildContext context)
        {
            foreach (var component in context.GetComponents<ReduceSkinnedMeshComponent>())
            {
                var skinnedMeshRenderer = component.GetComponent<SkinnedMeshRenderer>();
                var meshSimplifier = new MeshSimplifier(skinnedMeshRenderer.sharedMesh);

                if (component.isLossless)
                {
                    meshSimplifier.SimplifyMeshLossless();
                }
                else
                {
                    meshSimplifier.SimplifyMesh(component.quality);
                }
                
                skinnedMeshRenderer.sharedMesh = meshSimplifier.ToMesh();

                component.RemoveProcessing();
            }
        }
    }
}
