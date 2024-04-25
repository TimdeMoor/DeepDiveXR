using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(RoomTile))]
public class RoomTileEditor : Editor
{
    public override void OnInspectorGUI()
    {
        RoomTile tile = (RoomTile)target;

        //EditorGUILayout.EnumPopup(WallType);
    }
}
