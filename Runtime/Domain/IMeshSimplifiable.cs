using UnityEngine;

namespace AdzukiMe.PolygonReducer.Domain
{
    internal interface IMeshSimplifiable
    {
        Mesh Mesh { init; }
        
        Mesh GetSimplified(float quality);
        Mesh GetSimplifiedLossless();
    }
}
