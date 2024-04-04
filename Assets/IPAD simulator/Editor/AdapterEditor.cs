using UnityEditor;
using UnityEngine;

namespace IPAD_simulator.Editor
{
    [CustomEditor(typeof(Adapter))]
    public class AdapterEditor : UnityEditor.Editor
    {
        [SerializeField] private Adapter _adapter;

        public override void OnInspectorGUI()
        {
            base.OnInspectorGUI();
            if (GUILayout.Button("ShowIPadView"))
                _adapter.ActiveViewIPad();

            if (GUILayout.Button("ShowIPhoneView"))
                _adapter.ActiveViewIPhone();
        }
    }
}