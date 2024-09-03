using UnityEngine;
using VRC.SDKBase;

namespace AdzukiMe.PolygonReducer.Components
{
    /// <summary>
    /// The components are expected to inherit this class.
    /// </summary>
    [DefaultExecutionOrder(-9997)] // Front of Av3Emulator
    public abstract class ComponentTag : MonoBehaviour, IEditorOnly
    {
        /// <summary>
        /// Removes the component itself during processing passes.
        /// </summary>
        internal void RemoveProcessing()
        {
            DestroyImmediate(this);
        }
    }
}
