using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StatsManager : MonoBehaviour
{
    public string userName;
    public int score;

    // Start is called before the first frame update
    void RemeberName()
    {
        GameObject.Find("buttonStart").GetComponent<Button>().interactable =
            GameObject.Find("userName").GetComponent<InputField>().text.Length >= 4 ? true : false;
        userName = GameObject.Find("userName").GetComponent<InputField>().text;
    }

}
