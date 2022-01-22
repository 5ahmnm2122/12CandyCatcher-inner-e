using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour
{
    [SerializeField] Text scoreText;

    [SerializeField] int scoreCount;

    // [SerializeField] Text playerName;




    public void RaiseScore()
    {
        scoreCount++;
        scoreText.text = scoreCount.ToString();
        
    }

    
}