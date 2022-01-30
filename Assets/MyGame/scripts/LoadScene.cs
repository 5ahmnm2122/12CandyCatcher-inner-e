using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoadScene : MonoBehaviour
{
    public GameObject scoreManagerGO;
    public GameObject nameManagerGO;
    [SerializeField] Text scoreAndNameText;

    private void Start()
    {
        scoreManagerGO = GameObject.FindGameObjectWithTag("ScoreManager");
        nameManagerGO = GameObject.FindGameObjectWithTag("Statmanager");
        scoreAndNameText.text = nameManagerGO.GetComponent<DataManager>().playerNameString + ", " + scoreManagerGO.GetComponent<ScoreManager>().scoreCount.ToString();
    }

    public void ChangeScene()
    {
        Destroy(scoreManagerGO);
        Destroy(nameManagerGO);
        SceneManager.LoadScene(0);
    }
}