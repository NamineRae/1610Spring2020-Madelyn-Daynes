using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class 'Assets.Tutorial_Scripts' : MonoBehaviour
{
    // This is the color changer
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            GetComponent<Renderer>
                ().material.color = Color.red;
        }

        if (Input.GetKeyDown(KeyCode.G))
        {
            GetComponent<Renderer>
                ().material.color = Color.green;
        }

        if (Input.GetKeyDown(KeyCode.b))
        {
            GetCOmponent<Renderer>
                ().material.color = Color.blue;
        }
    }
}


  
