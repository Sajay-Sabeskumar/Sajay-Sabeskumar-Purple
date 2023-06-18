using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Node : MonoBehaviour
{
    public LayerMask obstacleLayer;
    public List<Vector2> availiableDirections;

    void Start()
    {
        availableDirections = new List<Vector2>();   
    }
}
