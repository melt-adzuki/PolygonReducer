using JetBrains.Annotations;
using nadena.dev.ndmf;
using UnityEngine;

namespace AdzukiMe.PolygonReducer.Editor
{
    internal static class Extensions
    {
        internal static T[] GetComponents<T>([NotNull] this BuildContext context)
            where T : Component
        {
            return context.AvatarRootObject.GetComponentsInChildren<T>();
        }
    }
}
