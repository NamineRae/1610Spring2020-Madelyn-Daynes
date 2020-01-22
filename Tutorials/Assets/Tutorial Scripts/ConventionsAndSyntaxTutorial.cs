using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConventionsAndSyntaxTutorial : MonoBehaviour
{

    void Start()
    {
        Debug.Log(transform.position.x);

        if (transform.position.y <= 5f)
        {
            Debug.Log("I'm about to hit the ground!");
        }
    }
}

// This is from a Unity Learn Tutorial
/* YAY
SO 
MANY
TUTORIALS
THIS IS
LOTS OF FUN*/