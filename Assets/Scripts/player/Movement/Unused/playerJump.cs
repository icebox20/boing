using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerJump : MonoBehaviour
{



    private Rigidbody2D physicsThingy;
    private bool isJumpKeyDown = false;
    public float jumpMagnitude = 5;

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

       // Debug.Log(" " +flatVelocity);


        if (isJumpKeyDown)
        {
            
            
            physicsThingy.velocity = new Vector2(flatVelocity, jumpMagnitude);


        }
    }
}
