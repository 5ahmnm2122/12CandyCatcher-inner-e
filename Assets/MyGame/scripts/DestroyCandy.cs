using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DestroyCandy : MonoBehaviour
{
    [SerializeField] ScoreManager script;
    public BoxCollider2D playerRb;
    public GameObject player;
    public int scoreInt;


    public void OnTriggerEnter2D(Collider2D collider)
    {
        Debug.Log("Object is triggered");
        if (collider.tag == "Player")
        {

            Debug.Log("Object is triggered by player");
            script.RaiseScore();
            Destroy(this.gameObject);

        }

    } 

}
