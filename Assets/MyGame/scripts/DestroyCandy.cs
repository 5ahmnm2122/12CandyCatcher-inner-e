using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DestroyCandy : MonoBehaviour
{



    void OnCollideEnter()
    {
        GameObject.FindWithTag("ScoreManager")/*.RaiseScore()*/;
        Destroy(this.gameObject);

    } 

}
