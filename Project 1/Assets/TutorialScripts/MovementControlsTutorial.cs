﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementControlsTutorial : MonoBehaviour
{
    public float speed;
    public float turnSpeed;
    void Update ()
    {
        MovementControlsTutorial();
    }

    void Movement ()
    {
        float forwardMovement = Input.GetAxis("Vertical") * speed * Time.deltaTime;
        float turnMovement = Input.GetAxis("Horizontal") * turnSpeed * Time.deltaTime;
        
        transform.Translate(Vector3.forward * forwardMovement);
        transform.Rotate(Vector3.up * turnMovement);
    }
}
//unity learn tutorial