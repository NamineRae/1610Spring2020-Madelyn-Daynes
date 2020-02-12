using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Light))]
public class LightThing : MonoBehaviour
{
    public Light Lightobj;
 
    void Update()
    {
        
        bool down = Input.GetKeyDown(KeyCode.P);
        if (down)
        {
            Lightobj.GetComponent<Light>().color = new Color(255, 0, 242);
        }
    }
}
// code base found here https://answers.unity.com/questions/1211937/change-color-in-c-with-rgb-values.html