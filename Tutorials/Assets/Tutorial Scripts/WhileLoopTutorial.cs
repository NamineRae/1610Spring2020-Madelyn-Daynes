using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Note to self: IT AINT WORKIN GET HELP
public class WhileLoopTutorial : MonoBehaviour
{
    int cupsInTheSink = 4;

    void Start()
    {
        while (cupsInTheSink > 0)
        {
            Debug.Log("I've washed a cup!");
            cupsInTheSink--;
        }
    }
}
//I am copying the code, but its re-typing it by hand, not copy-and-paste
/*this
is
from
a 
unity
learn
tutorial*/