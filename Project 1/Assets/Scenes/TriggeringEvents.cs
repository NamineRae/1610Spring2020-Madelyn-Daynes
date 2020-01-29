using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TriggeringEvents : MonoBehaviour
{
    private int triggerInteger;

    private float triggerFloat;

    private string triggerString;

    public UnityEvent triggeringEnterEvent;

    public void OnTriggerEnter(Collider other)
    { 
        triggeringEnterEvent.Invoke();
    }

    public UnityEvent triggeringStayEvent;

    public void OnTriggerStay(Collider other)
    {
        triggeringStayEvent.Invoke();
    }

    public UnityEvent triggeringExitEvent;

    public void OnTriggerExit(Collider other)
    {
        triggeringExitEvent.Invoke(); 
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
