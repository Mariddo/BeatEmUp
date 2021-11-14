using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterShadow : MonoBehaviour
{
    public GameObject character;

    public bool characterTouchingShadow;
    
    // Start is called before the first frame update
    void Start()
    {
        characterTouchingShadow = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D col)
    {


    }
}
