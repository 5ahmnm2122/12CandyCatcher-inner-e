using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DestroyCandyBad : MonoBehaviour
{
   
    public BoxCollider2D playerRb;

  


    public void OnTriggerEnter2D(Collider2D collider)
    {
        Debug.Log("Object is triggered");
        if (collider.tag == "Player")
        {

            Debug.Log("Object is triggered by player");
            Destroy(this.gameObject);
            SceneManager.LoadScene("EndScene");

        }

    } 

}
