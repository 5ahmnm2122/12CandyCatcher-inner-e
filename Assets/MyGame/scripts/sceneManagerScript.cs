using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class sceneManagerScript : MonoBehaviour
{
    //public GameObject scoreScriptGO;
    public GameObject nameScriptGO;
    [SerializeField] Text playerNameText;

    void Start()
    {
        //scoreScriptGO = GameObject.FindGameObjectWithTag("ScoreManager");
        nameScriptGO = GameObject.FindGameObjectWithTag("Statmanager");
        playerNameText.text = nameScriptGO.GetComponent<DataManager>().playerNameString;
        //Debug.Log(nameScriptGO.GetComponent<DataManager>().playerNameString);
    }

    void Update()
    {
        //Debug.Log(scoreScriptGO.GetComponent<ScoreManager>().scoreCount.ToString());
    }
}
