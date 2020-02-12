using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyBasicTutorial : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            Destroy(gameObject, 3f);
        }
    }
}
//from unity learn tutorial