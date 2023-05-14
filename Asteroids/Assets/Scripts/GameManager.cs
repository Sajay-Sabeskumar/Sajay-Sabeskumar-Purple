using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject rockPrefab;
    public Transform[] spawnPoints;
    // Start is called before the first frame update
    void Start()
    { 
    // Starts at 0 and stops when it reaches 4, so 4 loops total    
        for (int i = 0; i <4; i++)
        {
            Vector3 randomPosition = spawnPoints[Random.Range(0,3)].position;
            Instantiate(rockPrefab, randomPosition, Quaternion.identity);
        }
        
    }


}
