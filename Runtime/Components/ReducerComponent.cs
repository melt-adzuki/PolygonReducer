namespace AdzukiMe.PolygonReducer.Components
{
    /// <summary>
    /// A component base that to be used by Polygon Reducer.
    /// </summary>
    internal abstract partial class ReducerComponent : ComponentTag
    {
        public bool isLossless = false;
        public float quality = 0.5f;
        public bool showsLOD = true;
        
        public bool IsPreviewing { get; private set; } = false;
    }
}
