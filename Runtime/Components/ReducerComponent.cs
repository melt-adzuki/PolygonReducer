using UnityEngine;
using UnityEngine.Serialization;

namespace AdzukiMe.PolygonReducer.Components
{
    /// <summary>
    /// A base of components that to be used by Polygon Reducer.
    /// </summary>
    public abstract class ReducerComponent : ComponentTag
    {
        // TODO: Add preview button
        
        [SerializeField] public bool isLossless = false;
        [SerializeField] public float quality = 0.5f;
    }
}
