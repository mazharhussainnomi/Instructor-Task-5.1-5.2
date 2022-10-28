using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHorizontalMovement : MonoBehaviour
{
    public float speed = 5f; //Create a public speed variable to control how fast the player will move
                             //http:levelup.gitconnected.com/how-to-add-simple-player-movement-in-unity-67ae832529fd
                             //bestexplained
    public float horizontalInput; //Create variables to store the directional values horizontaly
    public float verticalInput;     //Create variables to store the directional values vertically
    public Vector3 direction; //used a vector to store the directional values



    void Start()
    {
        
    }

    
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        direction = new Vector3(horizontalInput, verticalInput,0);
        transform.Translate(direction * speed * Time.deltaTime); //Used tranform.Translate to initiate the movement calculation.
        //Time.deltaTime is used so that the movement takes place in realtime rather than by frame.


    }
}
