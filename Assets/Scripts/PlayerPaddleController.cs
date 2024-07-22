using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPaddleController : PaddleController
{    
       
    private void FixedUpdate()
    {        
        PaddleMovement();
    }

    

    private void PaddleMovement() 
    {
        float vertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(0,vertical,0);
        transform.Translate( movement * _paddleSpeed * Time.deltaTime );
    }
}
