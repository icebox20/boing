using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerJumpImproved : MonoBehaviour
{



    private Rigidbody2D physicsThingy;
    private bool isJumpKeyDown = false;
    public float jumpMagnitude = 5;
    public float groundLeniency = 1;

    void Start()
    {
        physicsThingy = GetComponent<Rigidbody2D>();

    }

    void Update()
    {
        isJumpKeyDown = Input.GetButton("Jump");

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //  isJumpKeyDown = Input.GetButtonDown("Jump");
        float flatVelocity = physicsThingy.velocity.x;

        RaycastHit2D ground = Physics2D.Raycast(this.gameObject.transform.position, -Vector2.up);



        if (ground.collider != null)
        {
            float distance = ground.distance;
            //Debug.Log("Hit a thing, "+distance);
         
            if(distance<groundLeniency)
            {
               //Debug.Log("WithinRange");
                if (physicsThingy.velocity.y <= 0)
                {
                    //Debug.Log("fall/grounded check worked");
                    if (isJumpKeyDown)
                    {


                        physicsThingy.velocity = new Vector2(flatVelocity, jumpMagnitude);


                    }

                }

             


            }

              

        }
        else
        {
            //Debug.Log("the ground thing says NO");
        }

    }
}
