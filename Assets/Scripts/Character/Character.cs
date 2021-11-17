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

    Rigidbody2D spriteRigid;

    public float inputHorizontal;
    public float inputVertical;

    public bool isGrounded;

    public bool isLimp;



    // Start is called before the first frame update
    void Start()
    {
        SetUpCharacter();

    }

    protected void SetUpCharacter()
    {
        //Initialize the children
        characterSprite = this.gameObject.transform.GetChild(0).gameObject;

        spriteRigid = characterSprite.GetComponent<Rigidbody2D>();

        //Initialize Input fields.
        inputHorizontal = inputVertical = 0;

        yOffset = transform.position.y;

        isGrounded = false;

        isLimp = false;



    }

    protected void DetermineIfGrounded()
    {
        if(characterSprite.transform.position.y <= yOffset)
        {
            isGrounded = true;
        }

    }

    protected void Grounded()
    {
        if(isGrounded)
        {
            characterSprite.GetComponent<Rigidbody2D>().gravityScale = 0;
        }
        else
        {
            characterSprite.GetComponent<Rigidbody2D>().gravityScale = 1;
        }

    }


    // Update is called once per frame
    void Update()
    {
        DetermineIfGrounded();
        Grounded();

        Movement();
        

    }

    protected void Movement()
    {
        spriteRigid.velocity = new Vector2(inputHorizontal * walkSpeedHorizontal, inputVertical * walkSpeedVertical);

    }







}
