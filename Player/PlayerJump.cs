using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJump : MonoBehaviour
{
    public float distanceToGround;
    public float jumpSpeed;
    public LayerMask Ground;


    [SerializeField]
    private bool onGround;
    private Rigidbody2D myRB;
    private Animator myAnimator;

    void Awake()
    {
        myRB = GetComponent<Rigidbody2D>();
        myAnimator = GetComponent<Animator>();
    }

       void Update()
    {
       
        if(Physics2D.Raycast(transform.position, Vector3.down, distanceToGround, Ground))
            {
            onGround = true;
        }else {
            onGround = false;
}

        if (Input.GetKeyDown(KeyCode.Space)&& onGround)
        {
            myRB.velocity = new Vector2(myRB.velocity.x, jumpSpeed);
            onGround = false;

        }

        myAnimator.SetBool("Grounded", onGround);
    }
}
