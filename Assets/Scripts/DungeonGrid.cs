using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DungeonGrid : MonoBehaviour
{
    private void OnGUI()
    {
        if (GUILayout.Button("Generate Grid"))
        {
            Generate();
        }
    }

    private void Generate()
    {
        Debug.Log("Done");
    }
}
