using AdzukiMe.PolygonReducer.Domain;
using AdzukiMe.PolygonReducer.Infrastructure;
using AdzukiMe.PolygonReducer.Services;
using UnityEngine;

namespace AdzukiMe.PolygonReducer.Components
{
    /// <summary>
    /// A component base that to be used by Polygon Reducer.
    /// </summary>
    internal abstract class ReducerComponent : ReducerComponentOptions
    {
        public bool IsPreviewing { get; private set; } = false;

        // TODO: Why doesn't it complain about null?
        protected IMeshRepository Mesh { get; set; }
        protected abstract void SetMeshFromComponent();

        private Mesh _originalMesh;

        public void StartPreview()
        {
            // _skinnedMeshRenderer = GetComponent<SkinnedMeshRenderer>();
            SetMeshFromComponent();
            
            IsPreviewing = true;
            _originalMesh = Mesh.Value;

            ReduceMeshService<MeshSimplifiableUMS>.Process(Mesh, options: this);
        }

        public void StopPreview()
        {
            IsPreviewing = false;
            Mesh.Value = _originalMesh;
        }

        public void TogglePreview()
        {
            if (IsPreviewing) StopPreview();
            else StartPreview();
        }
    }
}
