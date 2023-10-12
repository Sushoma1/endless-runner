using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public LayerMask whatIsGround;
    public GameObject groundChecker;
    public float maxSpeed = 5.0f;
    bool isOnGround = false;
    
    public float currentHealth;
    bool instantKill = true;
    public float maxHealth;
    float jumpForce = 5.0f; 

    //Create a reference t0 the RigidBogy2D so we can manupilate it
    Rigidbody2D playerObject;

    // Start is called before the first frame update
    void Start()
    {
        //Find the RigidBody2D component that is attached to the same object as the script
        playerObject = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
       
        //Create a 'float' that will be equal to the players horizontal input

        //float movementValueX to 1.0f, so that we always run forward and no longer care about player input
        float movementValueX = 1.0f;

        //Create a 'float' that will be equal to the players horizontal input
        //float movementValueX = Input.GetAxis("Horizontal");
        
        //Change the X velocuty of the Rigidbody2D to be equal to the movement value
        playerObject.velocity = new Vector2(movementValueX*10, playerObject.velocity.y);

        //Check to se if the ground check object is touching the ground
        isOnGround = Physics2D.OverlapCircle(groundChecker.transform.position, 1.0f, whatIsGround);

        if ((isOnGround == true) && (Input.GetAxis("Jump") > 0.0f))
        {
            playerObject.AddForce(Vector2.up*jumpForce);
        }

        if ((currentHealth < 0.0f) || (instantKill == true))
        {
            //Game over
        }

        if (currentHealth != maxHealth)
        {
            //Heal
        }
    }
}
