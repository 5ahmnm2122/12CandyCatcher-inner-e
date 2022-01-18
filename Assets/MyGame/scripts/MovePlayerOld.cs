/*  using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayerOld : MonoBehaviour
{

 public GameObject player;
  int speed = 20;
   float multiplier = 7f;


   // Update is called once per frame
   private void Update()
   {
       if (Input.GetKeyDown(KeyCode.LeftArrow))
       {
          GetComponent<Rigidbody2D>().velocity = new Vector2(-speed * multiplier, 0);
           player.transform.Rotate(0, -180, 0);


       }

       if (Input.GetKeyDown(KeyCode.RightArrow))
       {
           GetComponent<Rigidbody2D>().velocity = new Vector2(speed * multiplier, 0);
           player.transform.Rotate(0, 180, 0);

       }





   }
}

*/
