using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D myRB;
    
    public float moveSpeed;
    

        void Awake()
    {
        myRB = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        myRB.velocity = new Vector2(moveSpeed, myRB.velocity.y);

    }

}
