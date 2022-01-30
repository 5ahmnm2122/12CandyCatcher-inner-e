using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneManagement : MonoBehaviour
{
    /*    public GameObject pickupScriptVar;
        public GameObject sceneSwitchScripter;
        [SerializeField] Text scorePlusNameText;
        void Start()
        {
            //searches for static objects and assigns them to variable
            pickupScriptVar = GameObject.FindGameObjectWithTag("ScoreHolder");
            sceneSwitchScripter = GameObject.FindGameObjectWithTag("SceneSwitch");
            // scorePlusNameText.text = pickupScriptVar.scoreInt.ToString() + ", " + sceneSwitchScripter.playerNameText;
            scorePlusNameText.text = "Score: " + pickupScriptVar.GetComponent<DestroyCandy>().scoreInt.ToString() + ", Name: " + sceneSwitchScripter.GetComponent<LoadScene>().playerNameText;
        }
        public void ReloadMainScene()
        {
            Destroy(pickupScriptVar);
            Destroy(sceneSwitchScripter);
            SceneManager.LoadScene("MainScene");
        }
    */
}