using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformSpawner : MonoBehaviour
{

    public GameObject platformPrefab;
    public int count = 3;

    public float timeBestSpawnMin = 1.25f;
    public float timeBestSpawnMax = 2.25f;
    private float timeBestSpawn;

    public float yMin = -3.5f;
    public float yMax = 1.5f;
    private float xPos = 20f;

    private GameObject[] platforms;
    private int currentIndex = 0;

    private Vector2 poolPosition = new Vector2(0, -25f);
    private float lastSpawnTime;
    // Start is called before the first frame update
    void Start()
    {
        platforms = new GameObject[count];
        
        for(int i=0; i< count; i++)
        {
            platforms[i] = Instantiate(platformPrefab, poolPosition, Quaternion.identity);
        }

        lastSpawnTime = 0f;
        timeBestSpawn = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        if(GameManager.instance.isGameover)
        {
            return;
        }
        if(lastSpawnTime + timeBestSpawn <=Time.time)
        {
            lastSpawnTime = Time.time;
            timeBestSpawn = Random.Range(timeBestSpawnMin, timeBestSpawnMax);

            float yPos = Random.Range(yMin, yMax);
            platforms[currentIndex].SetActive(false);
            platforms[currentIndex].SetActive(true);
            platforms[currentIndex].transform.position = new Vector2(xPos, yPos);
            currentIndex += 1;

            if(count <= currentIndex)
            {
                currentIndex = 0;
            }
        }
    }
}
