using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Waypoint : MonoBehaviour
{
    [SerializeField] GameObject towerPrefab;
    [SerializeField] bool isPlaced;
    void OnMouseDown() 
    {   
        if (isPlaced)
        {
            Instantiate(towerPrefab, transform.position, Quaternion.identity);
            isPlaced = false;
        }
    }
}
