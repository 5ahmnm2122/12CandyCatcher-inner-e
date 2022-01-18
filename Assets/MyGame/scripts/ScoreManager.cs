using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour
{
    [SerializeField] Text scoreText;

    [SerializeField] int scoreCount;

    [SerializeField] Text playerName;

    [SerializeField] int timer = 60;

    [SerializeField] float currentTime;

    [SerializeField] Text timerText;

    [SerializeField] string sceneName;


    public void Start()
    {

        currentTime = timer;
    }

    public void RaiseScore()
    {
        scoreCount++;
        scoreText.text = scoreCount.ToString();
    }

    void Update() {

        currentTime -= 1 * Time.deltaTime;
        timerText.text = currentTime.ToString();
       


        if (timer == 0)
        {

            SceneManager.LoadScene(sceneName);
           
        }

     

    }
}