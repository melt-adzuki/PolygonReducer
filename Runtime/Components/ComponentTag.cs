using UnityEngine;
using VRC.SDKBase;

namespace AdzukiMe.PolygonReducer.Components
{
    /// <summary>
    /// The components are expected to inherit this class.
    /// </summary>
    [DefaultExecutionOrder(-9997)] // Front of Av3Emulator
    internal abstract class ComponentTag : MonoBehaviour, IEditorOnly
    {
        
    }
}
