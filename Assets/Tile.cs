using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile : MonoBehaviour
{
    [SerializeField] private GameObject TilePrefab;
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(TilePrefab);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
