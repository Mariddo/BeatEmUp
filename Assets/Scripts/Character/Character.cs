using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    public float walkSpeedHorizontal = 3.0f;

    public float walkSpeedVertical = 1.0f;

    public float jumpForce = 5.0f;

    public float yOffset;

    GameObject characterSprite;

    GameObject characterShadow;

    public float inputHorizontal;
    public float inputVertical;

    public bool isGrounded;



    // Start is called before the first frame update
    void Start()
    {
        SetUpCharacter();

    }

    protected void SetUpCharacter()
    {
        //Initialize the children
        characterSprite = this.gameObject.transform.GetChild(0).gameObject;
        characterShadow = this.gameObject.transform.GetChild(1).gameObject;



        //Initialize Input fields.
        inputHorizontal = inputVertical = 0;

        yOffset = transform.position.y;

        isGrounded = false;




    }

    protected void DetermineIfGrounded()
    {
        if(characterSprite.transform.position.y <= yOffset)
        {
            isGrounded = true;
        }
        else
        {
            isGrounded = false;
        }

    }

    protected void UpdateGravity()
    {
        if(isGrounded)
        {
            characterSprite.GetComponent<Rigidbody2D>().gravityScale = -1;
        }
        else
        {
            characterSprite.GetComponent<Rigidbody2D>().gravityScale = 1;
        }

    }

    protected void VerticalGroundMovement()
    {
        if(isGrounded && inputVertical == 0)
        {
            Vector2 velocity = characterSprite.GetComponent<Rigidbody2D>().velocity;

            characterSprite.GetComponent<Rigidbody2D>().velocity = new Vector2(velocity.x, 0);
        }

    }

    // Update is called once per frame
    void Update()
    {
        DetermineIfGrounded();
        UpdateGravity();
        VerticalGroundMovement();


    }


    void Move()
    {


    }


}
