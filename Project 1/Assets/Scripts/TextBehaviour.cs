﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Text))]
public class TextBehaviour : MonoBehaviour
{
    private Text textObj;
    public IntData dataObj;
    void Start()
    {
        textObj = GetComponent<Text>();
    }
    void Update()
    {
        textObj.text = dataObj.value.ToString();
    }

    public void ChangeText(IntData obj)
    {
        textObj.text = obj.value.ToString();
    }
    
}
