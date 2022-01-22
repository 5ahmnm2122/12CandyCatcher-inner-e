using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StatsManager : MonoBehaviour
{
    public string userName;
    public int score;
    public Text playersName;
    public InputField nameInput;
    public static string nameOfPlayer;
    public Text scoreText;
    public static int scoreUpdate = 0;


    private void Update()
    {
       playersName.text = nameOfPlayer;
       
    }


    public void Reset()
    {

        var InputField = nameInput.GetComponent<InputField>();
        InputField.text = playersName.text;

    }

    /* void RemeberName()
    {
       
        GameObject.Find("buttonStart").GetComponent<Button>().interactable =
            GameObject.Find("userName").GetComponent<InputField>().text.Length >= 4 ? true : false;
        userName = GameObject.Find("userName").GetComponent<InputField>().text;
    }
     */
}
