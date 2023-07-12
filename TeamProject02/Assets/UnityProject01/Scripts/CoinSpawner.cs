using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSpawner : MonoBehaviour
{
    public GameObject coinPrefab;
    public int count = 3;

    public float timeBestSpawnMin = 1.25f;
    public float timeBestSpawnMax = 2.25f;
    private float timeBestSpawn;

    public float yMin = 1.5f;
    public float yMax = 1.5f;
    private float xPos = 20f;

    private int currentIndex = 0;

    private Vector2 poolPosition = new Vector2(0, -25f);
    private float lastSpawnTime;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
