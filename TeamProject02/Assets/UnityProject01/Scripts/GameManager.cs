using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public bool isGameover = false;
    public TMP_Text scoreText;
    public GameObject gameoverUi;

    private int score = 0;

    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
        else
        {
            GFunc.LogWarning("씬에 두 개 이상의 게임 메니저가 존재합니다");
            Destroy(gameObject);
        }    
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(isGameover == true && Input.GetMouseButtonDown(0))
        {
            GFunc.LoadScene(GFunc.GetActiveSceneName());
        }
    }
    public void AddScore(int newScore)
    {
        if(isGameover == false)
        {
            score += newScore;
                scoreText.text = string.Format("Score : {0}", score);

        }
    }
    public void OnPlayerDead()
    {
        isGameover = true;
        gameoverUi.SetActive(true);
    }
}
