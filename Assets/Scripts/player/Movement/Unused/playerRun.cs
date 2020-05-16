using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerRun : MonoBehaviour
{



    private Rigidbody2D physicsThingy;
    public float acceleration = 5;
    public float speedCap = 8;
    private float flatVelocity = 0;

    void Start()
    {
        physicsThingy = GetComponent<Rigidbody2D>();
    }

    void Update()
    {

       flatVelocity = acceleration*Input.GetAxis("Horizontal");

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //Debug.Log(" "+flatVelocity);

       // Vector2 movement = new Vector2(flatVelocity, 0);

       // physicsThingy.AddForce(movement * acceleration);




        if ((physicsThingy.velocity.x < -speedCap) && (physicsThingy.velocity.x > speedCap))
        {
            Vector2 movement = new Vector2(flatVelocity, 0);

            physicsThingy.AddForce(movement * acceleration);
        }
    }
}
