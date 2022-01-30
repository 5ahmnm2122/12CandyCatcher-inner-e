
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class DataManager : MonoBehaviour
{
    [SerializeField] Text inputField;
    public string playerNameString;

    private void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }

    public void SceneSwitch()
    {
         SceneManager.LoadScene(1);
         playerNameString = inputField.text;
        //Debug.Log(inputField.text);
    }
}

