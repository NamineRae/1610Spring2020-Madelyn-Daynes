using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class ForLoopTutorial : MonoBehaviour
{
    private int numEnemies = 3;

    void Start()
    {
        for (int i = 0; i < numEnemies; i++)
        {
            Debug.Log("Creating enemy number: " + i);
        }
    }
}
/* This
is 
from
a 
unity
learn
tutorial
about
loops*/