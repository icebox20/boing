using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerAnimate : MonoBehaviour
{

	private Rigidbody2D playerRigidbody;
    private Animator playerAnimator;
    private SpriteRenderer playerSpriteRenderer;

    void Start()
    {
        playerAnimator = GetComponent<Animator>();
        playerRigidbody = GetComponent<Rigidbody2D>();
        playerSpriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        playerAnimator.SetFloat("Speed", playerRigidbody.velocity.x);

        if(Input.GetAxis("Horizontal") > 0)
        {
        	playerSpriteRenderer.flipX = false;
        }
        else if(Input.GetAxis("Horizontal") < 0)
        {
        	playerSpriteRenderer.flipX = true;
        }
    }
}
