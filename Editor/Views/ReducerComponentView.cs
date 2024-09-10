using AdzukiMe.PolygonReducer.Components;
using UnityEditor;
using UnityEngine;

namespace AdzukiMe.PolygonReducer.Editor.Views
{
    [CustomEditor(typeof(ReducerComponent), editorForChildClasses: true)]
    internal class ReducerComponentView : UnityEditor.Editor
    {
        private string _previewButtonText;
        
        public override void OnInspectorGUI()
        {
            var component = (ReducerComponent)target;
            
            EditorGUILayout.LabelField("Description of the component comes here.");
            EditorGUILayout.Space();

            component.isLossless = EditorGUILayout.Toggle(
                label: "Lossless",
                value: component.isLossless);

            using (new EditorGUI.DisabledScope(component.isLossless))
                component.quality = EditorGUILayout.Slider(
                    label: "Quality",
                    value: component.quality,
                    leftValue: 0.0f,
                    rightValue: 1.0f);
            
            EditorGUILayout.Space();
            
            _previewButtonText = !component.IsPreviewing
                ? "Start Preview" : "Stop Preview";
            
            if (GUILayout.Button(_previewButtonText))
                component.TogglePreview();
            
            if (component.IsPreviewing)
                component.showsLOD = EditorGUILayout.Toggle(
                    label: "Show LOD",
                    value: component.showsLOD);
        }
    }
}
