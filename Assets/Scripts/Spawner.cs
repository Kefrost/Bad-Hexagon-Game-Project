using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public float spawnRate = 1f;
    public GameObject hexagon;
    float readyToSpawn = 0f;

    // Update is called once per frame
    void Update()
    {
        if (Time.time >= readyToSpawn)
        {
            Instantiate(hexagon, Vector3.zero, Quaternion.identity);
            readyToSpawn = Time.time + 1f / spawnRate;
        }
    }
}
