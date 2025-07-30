using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(DungeonGrid))]
public class DungeonGridEditor : Editor
{
    public override void OnInspectorGUI()
    {
        DungeonGrid grid = (DungeonGrid) target;
        EditorGUILayout.FloatField("Width", grid.width);
        EditorGUILayout.FloatField("Height", grid.height);

        
    }
}