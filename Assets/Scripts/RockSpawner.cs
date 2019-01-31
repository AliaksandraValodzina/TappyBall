using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockSpawner : MonoBehaviour
{
    public float maxYpos;
    public float spawnTime;
    public GameObject rockObject;

    // Start is called before the first frame update
    void Start()
    {
        // SpartSpawningRocks();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void StopSpawningRocks()
    {
        CancelInvoke("SpartSpawningRocks");
    }

    public void SpartSpawningRocks()
    {
        InvokeRepeating("SpawnRocks", 0.2f, spawnTime);
    }

    void SpawnRocks()
    {
        Instantiate(rockObject, new Vector3(transform.position.x, Random.Range(-maxYpos, maxYpos), 0), Quaternion.identity);
    }
}
