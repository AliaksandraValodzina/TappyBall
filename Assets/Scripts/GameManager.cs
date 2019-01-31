using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    bool isGameOver;

    void Awake()
    {
        DontDestroyOnLoad(this.gameObject);

        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(this.gameObject);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        isGameOver = false;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void GameStart()
    {
        GameObject.Find("RockSpawner").GetComponent<RockSpawner>().SpartSpawningRocks();
        UiManager.instance.GameStart();
    }

    public void GameOver()
    {
        isGameOver = true;
        GameObject.Find("RockSpawner").GetComponent<RockSpawner>().StopSpawningRocks();
        UiManager.instance.GameOver();
        ScoreManager.instance.StopScore();
    }
}
