using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerRunImproved : MonoBehaviour
{



    private Rigidbody2D physicsThingy;
    public float acceleration = 5;
    public float speedCap = 8;
    private float flatVelocity = 0;
    public float adjuster = 5;

    void Start()
    {
        physicsThingy = GetComponent<Rigidbody2D>();
    }

    void Update()
    {

        flatVelocity = acceleration * Input.GetAxis("Horizontal");

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //Debug.Log(" "+flatVelocity);

        Vector2 movement = new Vector2(flatVelocity, 0);

        physicsThingy.AddForce(movement * acceleration);



        //checks to see if the player is going too fast to the left, and if so sets them to max left speed
        if ((physicsThingy.velocity.x < -speedCap)&&(Input.GetAxis("Horizontal")<0))
        {
            movement = new Vector2(flatVelocity, 0);

            physicsThingy.AddForce(movement * -acceleration);
        }

        //check to see fi the player is going too fast to the right, and if so sets them to max right speed.
        if ((physicsThingy.velocity.x > speedCap) && (Input.GetAxis("Horizontal") > 0))
        {
            movement = new Vector2(flatVelocity, 0); ;

            physicsThingy.AddForce(movement * -acceleration);
        }

    }
}
