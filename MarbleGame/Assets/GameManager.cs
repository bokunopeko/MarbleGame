using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager gm;
    public int score;

    public Text subtitle;
    public Text goScore;
    public Text goHudScore;
    public GameObject goPanel;

    public Text hudScore;
    public Text hudTimer;

    public float timer;
    bool gameOver;

    // Start is called before the first frame update
    void Start()
    {
        gameOver = false;
        goPanel.SetActive(false);

        score = 0;
        gm = this;

        Time.timeScale = 1;
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        hudScore.text = score.ToString();

        float calcTimer = timer;

        calcTimer = Mathf.Round(calcTimer * 100);
        calcTimer /= 100;

        hudTimer.text = calcTimer.ToString();

        if(timer <= 0 && !gameOver)
        {
            gameOver = true;
            Debug.Log("GameOver!");
            Time.timeScale = 0;
            goPanel.SetActive(true);

            if (score > PlayerPrefs.GetInt("highscore", 0))
            {
                PlayerPrefs.SetInt("highscore", score);
                subtitle.text = "NEW HIGH SCORE!";

            }
            else
            {
                subtitle.text = "BETTER LUCK NEXT TIME";
            }

            goScore.text = score.ToString();
            goHudScore.text = PlayerPrefs.GetInt("highscore", 0).ToString();
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(0);
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }


    }
}
