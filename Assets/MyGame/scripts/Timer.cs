using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    [SerializeField] int timer = 60;

    [SerializeField] float currentTime;

    [SerializeField] Text timerText;

    [SerializeField] string sceneName;


    void Update()
    {

        if (currentTime <= timer)
        {

            currentTime -= 1 * Time.deltaTime;
         


        }
        int timerUpdate = (int)currentTime;
        timerText.text = timerUpdate.ToString();

        if (currentTime <= 0)
        {

            SceneManager.LoadScene(sceneName);

        }

      



    }
}
