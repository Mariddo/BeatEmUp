using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    public float walkSpeedHorizontal = 3.0f;

    public float walkSpeedVertical = 1.0f;

    public float jumpForce = 5.0f;

    GameObject characterSprite;

    GameObject characterShadow;

    public float inputHorizontal;
    public float inputVertical;

    public bool isGrounded;

    bool touchingShadow;

    public float groundYLocation;

    public float groundXLocation;

    Rigidbody2D rigidBody;

    public bool inControl;



    // Start is called before the first frame update
    void Start()
    {
        SetUpCharacter();

    }

    protected void SetUpCharacter()
    {
        //Initialize the children
        characterSprite = this.gameObject.transform.GetChild(0).gameObject;

        inControl = true;

        //Initialize Input fields.
        inputHorizontal = inputVertical = 0;

        groundYLocation = transform.position.y;
        groundXLocation = transform.position.x;

        isGrounded = false;


        rigidBody = GetComponent<Rigidbody2D>();


    }

    protected void DetermineIfGrounded()
    {
        if(characterSprite.transform.position.y <= groundYLocation)
        {
            isGrounded = true;
        }
    }


    protected void VerticalGroundMovement()
    {
            

        //Vector2 velocity = characterSprite.GetComponent<Rigidbody2D>().velocity;

        //float groundedSpeed = isGrounded ? 0 : velocity.y;

        //characterSprite.GetComponent<Rigidbody2D>().velocity = new Vector2(velocity.x, groundedSpeed);
        
        rigidBody.velocity = new Vector2(rigidBody.velocity.x, walkSpeedVertical * inputVertical);

    }

    protected void HorizontalGroundMovement()
    {
        Vector2 velocity = characterSprite.GetComponent<Rigidbody2D>().velocity;

        characterSprite.GetComponent<Rigidbody2D>().velocity = new Vector2(inputHorizontal * walkSpeedHorizontal, velocity.y);
        
        if(inControl)
        {
            
        }

        rigidBody.velocity = new Vector2(walkSpeedHorizontal * inputHorizontal, rigidBody.velocity.y);

    }

    // Update is called once per frame
    void Update()
    {
        DetermineIfGrounded();
        RemainGrounded();
        VerticalGroundMovement();
        HorizontalGroundMovement();
        MoveCharacterSprite();


    }

    protected void RemainGrounded()
    {
        if(isGrounded)
        {
            characterSprite.transform.position = new Vector2(characterSprite.transform.position.x, groundYLocation);
        }

    }

    protected void TouchDown()
    {

        Vector2 velocity = characterSprite.GetComponent<Rigidbody2D>().velocity;

        characterSprite.GetComponent<Rigidbody2D>().velocity = new Vector2(velocity.x, 0);
    }


    protected void MoveCharacterSprite()
    {
        groundXLocation = transform.position.x;
        groundYLocation = transform.position.y;

       

    }


}
