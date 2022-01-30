using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour
{
    [SerializeField] Text scoreText;
    public int scoreCount;

    private void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }

    public void RaiseScore()
    {
        scoreCount++;
        scoreText.text = scoreCount.ToString();
    }
    
}