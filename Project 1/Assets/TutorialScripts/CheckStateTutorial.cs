﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckStateTutorial : MonoBehaviour
{
    public GameObject myObject;
    
    void Start()
    {
        Debug.Log("Active Self: " + myObject.activeSelf);
        Debug.Log("Active in Hierarchy" + myObject.activeInHierarchy);
    }

}
