﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class SingleTrigger : MonoBehaviour
{
    public UnityEvent triggerEnterEvent;

    private void OnTriggerEnter (Collider other)
    { 
        triggerEnterEvent.Invoke();
    }
}