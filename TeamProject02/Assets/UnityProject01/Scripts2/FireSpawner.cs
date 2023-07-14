using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class FireSpawner : MonoBehaviour
{
    public GameObject firePrefab;
    public GameObject firePrefab2;
    public float spawnRate = 0f;
    public float spawnRateMax = 3f;

    private float timeAfterSpawn;



    // Update is called once per frame
    void Update()
    {
        spawnRate += Time.deltaTime;
        if (spawnRate >= spawnRateMax)
        {
            spawnRate = 0f;
            int random = Random.Range(0, 2);


            if (random == 0)
            {
                Instantiate(firePrefab, transform.position, transform.rotation);
            }
            else if (random == 1)
            {
                Instantiate(firePrefab2, transform.position, transform.rotation);
            }
        }
    }
    
    //{
    //    Debug.Log("충돌했는가");
    //}
}
