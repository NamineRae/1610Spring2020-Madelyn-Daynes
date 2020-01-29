using System;
using UnityEngine;
using UnityEngine.Events;

public class TriggerEvents : MonoBehaviour
{
    public UnityEvent triggerEnterEvent;

    private void OnTriggerEnter(Collider other)
    {
        triggerEnterEvent.Invoke();
    }

public UnityEvent triggerStayEvent;

public void OnTriggerStay(Collider other)
    {
       triggerStayEvent.Invoke() ;
    }

public UnityEvent triggerExitEvent;
    public void OnTriggerExit(Collider other)
    {
        triggerExitEvent.Invoke();
    }
}
