using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseClickTutorial : MonoBehaviour
{
    void OnMouseDown()
    {
        GetComponent<Rigidbody>().AddForce(-transform.forward * 500f);
        GetComponent<Rigidbody>().useGravity = true;
    }
}
//unity learn tutorial