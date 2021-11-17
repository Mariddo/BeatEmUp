using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInputCatcher : MonoBehaviour
{

    private PlayerInputActions playerActionControls;

    public float moveVertical;
    public float moveHorizontal;
    public float jump;
    public float attack;

    void Awake()
    {
        playerActionControls = new PlayerInputActions();
        
    }

    private void OnEnable()
    {
        playerActionControls.Enable();
    }

    private void OnDisable()
    {
        playerActionControls.Disable();
    }

    // Start is called before the first frame update
    void Start()
    {
        moveVertical = moveHorizontal = jump = attack = 0f;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        UpdateInputs();
    }

    void UpdateInputs()
    {
        moveVertical = playerActionControls.Land.MoveVertical.ReadValue<float>();

        moveHorizontal = playerActionControls.Land.MoveHorizontal.ReadValue<float>();

        jump = playerActionControls.Land.Jump.ReadValue<float>();

        attack = playerActionControls.Land.Attack.ReadValue<float>();

    }
}
