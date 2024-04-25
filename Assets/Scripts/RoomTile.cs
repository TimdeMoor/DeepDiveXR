using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomTile : MonoBehaviour
{
    [SerializeField] private GameObject WallPrefab;
    [SerializeField] private GameObject DoorPrefab;
    public enum WallType
    {
        Empty,
        Door,
        Wall
    }

    private WallType NorthWall;
    private WallType EastWall;
    private WallType SouthWall;
    private WallType WestWall;
    
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
