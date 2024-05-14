using System.Collections;
using System.Collections.Generic;
using Autohand;
using UnityEngine;

public class GridManager : MonoBehaviour
{
    public List<GameObject> tiles;

    public void AddTile(PlacePoint p, Grabbable g)
    {
        Debug.Log(g.gameObject.name);
        tiles.Add(g.gameObject);
    }

    public void Disable()
    {
        foreach (GameObject go in tiles)
        {
            go.GetComponent<Collider>().enabled = false;
            go.GetComponent<Grabbable>().enabled = false;
        }
    }

    public void RemoveTile(PlacePoint p, Grabbable g)
    {
        tiles.Remove(g.gameObject);
    }
}
