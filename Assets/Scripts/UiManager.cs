using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UiManager : MonoBehaviour
{
    public static UiManager instance;
    public Text scoreText;
    public Text highScoreText;
    public GameObject gameOverPanel;
    public GameObject startUI;
    public GameObject gameOverText;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = ScoreManager.instance.score.ToString();
    }

    public void GameStart()
    {
        startUI.SetActive(false);
    }

    public void GameOver()
    {
        gameOverText.SetActive(true);
        highScoreText.text = PlayerPrefs.GetInt("HighScore").ToString();
        gameOverPanel.SetActive(true);
    }

    public void Replay()
    {
        SceneManager.LoadScene("level1");
    }

    public void Menu()
    {
        SceneManager.LoadScene("Menu");
    }
}
