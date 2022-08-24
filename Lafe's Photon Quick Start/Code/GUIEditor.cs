using UnityEngine;
using UnityEditor;

public class GUIEditorWindow : EditorWindow
{
    [MenuItem("Window/Lafe's Photon Quick Start")]
    public static void ShowWindow()
    {
        EditorWindow.GetWindow<GUIEditorWindow>("Lafe's Photon Quick Start");
    }

    private void OnGUI()
    {
        GUILayout.Space(20f);
        GUILayout.Label("Options | Disabled");
        GUILayout.Space(8f);

        GUILayout.Toggle(true, "Connection System");  
        GUILayout.Space(2.5f);
        GUILayout.Toggle(true, "Menu System");
        GUILayout.Space(2.5f);
        GUILayout.Toggle(true, "Player Instantiation System");

        GUILayout.Space(20f);
        if (GUILayout.Button("Implement Photon Quick Start", GUILayout.Height(50f)))
        {

        }
    }
}
