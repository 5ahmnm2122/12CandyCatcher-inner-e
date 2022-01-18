using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    [SerializeField]
    float speed = 100f;

    public Rigidbody2D player;

   
    void Start()
    {
        player.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        var movement = Input.GetAxis("Horizontal");
        transform.position += new Vector3(movement,0, 0) * Time.deltaTime * speed;
   

    if(!Mathf.Approximately(0,movement)){

            transform.rotation = movement > 0 ? Quaternion.Euler(0, 180, 0) : Quaternion.identity;


        }
    }
}
