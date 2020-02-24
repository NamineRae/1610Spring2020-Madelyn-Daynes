using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Image))]
public class ImageBehaviour : MonoBehaviour
{
    private Image imageObj;
    public FloatData dataObj;
    void Start()
    {
        imageObj = GetComponent<Image>();
    }
    
    void Update()
    {
        imageObj.fillAmount = dataObj.value; 
    }
}
//hw= try to get health image to reflect the float value