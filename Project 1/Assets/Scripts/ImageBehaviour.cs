using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Image))]
public class ImageBehaviour : MonoBehaviour
{
    private Image imageObj;
    void Start()
    {
        imageObj = GetComponent<Image>();
    }
    
    void Update()
    {
        
    }
}
//hw= try to get health image to reflect the float value