using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhileIfElse : MonoBehaviour
{
    void Start()
    {
        int counter = 10;
        while (counter > 0)
        {
            if(counter % 2 == 0)
            {
                print(counter + "is even");
            }
            else
            {
                print(counter + " is odd");
            }

            counter--;
        }

    }
   
}
