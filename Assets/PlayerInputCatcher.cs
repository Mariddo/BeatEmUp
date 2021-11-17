using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInputCatcher : MonoBehaviour
{
    
    PlayerActionControls playerActionControls;

    public float horizontal;
    public float vertical;

    public float attack;
    public float jump;
    

    void Awake()
    {
        playerActionControls = new PlayerActionControls();
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

    }

    // Update is called once per frame
    void Update()
    {
        horizontal = playerActionControls.Land.Horizontal.ReadValue<float>();
        vertical = playerActionControls.Land.Vertical.ReadValue<float>();

        attack = playerActionControls.Land.Attack.ReadValue<float>();
        jump = playerActionControls.Land.Jump.ReadValue<float>();
    }
}
