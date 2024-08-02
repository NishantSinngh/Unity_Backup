using System;
using TMPro;
using UnityEngine;

public class WayPoint : MonoBehaviour
{
    // this script is attached to prefab tile to get all tiles information
    [SerializeField] GameObject obstaclePrefab;

    // to instantiate an obstacle on the tile where you left click
    void OnMouseDown() {
        Instantiate(obstaclePrefab,transform.position,Quaternion.identity);    
    }
}
