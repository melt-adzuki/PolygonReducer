using UnityEngine;
using AdzukiMe.PolygonReducer.Components;
using nadena.dev.ndmf;

namespace AdzukiMe.PolygonReducer.Editor.Passes
{
    internal class RemovePolygonReducerComponentsPass : Pass<RemovePolygonReducerComponentsPass>
    {
        protected override void Execute(BuildContext context)
        {
            foreach (var component in context.GetComponents<ComponentTag>())
                Object.DestroyImmediate(component);
        }
    }
}
