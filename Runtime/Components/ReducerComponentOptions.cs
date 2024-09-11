namespace AdzukiMe.PolygonReducer.Components
{
    internal abstract class ReducerComponentOptions : ComponentTag
    {
        public bool isLossless = false;
        public float quality = 0.5f;
        public bool showsLOD = true;
    }
}
