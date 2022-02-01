using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class sceneManagerScript : MonoBehaviour
{

    public GameObject nameScriptGO;
    [SerializeField] Text playerNameText;

    void Start()
    {
      
        nameScriptGO = GameObject.FindGameObjectWithTag("Statmanager");
        playerNameText.text = nameScriptGO.GetComponent<DataManager>().playerNameString;
        
    }

    void Update()
    {
    
    }
}
