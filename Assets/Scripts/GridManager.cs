using System.Collections;
using System.Collections.Generic;
using Autohand;
using UnityEngine;

public class GridManager : MonoBehaviour
{
    [SerializeField] private GameObject PlacePointPrefab;
    private float cellSize = 1f;
    
    public float gridWidth = 11f;
    public float gridHeight = 11f;
    
    public List<GameObject> tiles;


    public void AddTile(PlacePoint p, Grabbable g)
    {
        Debug.Log(g.gameObject.name);
        tiles.Add(g.gameObject);
    }
    
    public void RemoveTile(PlacePoint p, Grabbable g)
    {
        tiles.Remove(g.gameObject);
    }

    public void SetColliders(bool val)
    {
        foreach (GameObject go in tiles)
        {
            go.GetComponent<Collider>().enabled = val;
            go.GetComponent<Grabbable>().enabled = val;
        }
    }

    


    public void UpdateGrid()
    {
        //First destroy all children
        while (transform.childCount > 0) {
            DestroyImmediate(transform.GetChild(0).gameObject);
        }

        //Create all gridcells
        for (int i = 0; i < gridWidth; i++)
        {
            for (int j = 0; j < gridHeight; j++)
            {
                Instantiate(PlacePointPrefab, new Vector3(i * cellSize, j * cellSize), Quaternion.identity);
            }
        }
    }
}
