using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyComponentTutorial : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            Destroy(GetComponent<MeshRenderer>());
        }
    }
}
//from unity learn tutorial