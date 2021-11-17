using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Character
{
    PlayerInputCatcher catcher;

    // Start is called before the first frame update
    void Start()
    {
        SetUpCharacter();

        catcher = GetComponent<PlayerInputCatcher>();
    }

    // Update is called once per frame
    void Update()
    {
        DetermineIfGrounded();
        RemainGrounded();
        
        GetInput();

        VerticalGroundMovement();
        HorizontalGroundMovement();
        MoveCharacterSprite();
    }

    void GetInput()
    {
        inputHorizontal = catcher.moveHorizontal;

        inputVertical = catcher.moveVertical;


    }

}
