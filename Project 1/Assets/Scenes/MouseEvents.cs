using System;
using UnityEngine;
using UnityEngine.Experimental.UIElements;
using UnityEngine.Events;

public class MouseEvents : MonoBehaviour
{
    public UnityEvent mouseDownEvent, mouseUpEvent, mouseExitEvent, mouseEnterEvent, mouseDragEvent, mouseOverEvent;
    private void OnMouseDown()
    {
    mouseDownEvent.Invoke();
    }
    
    private void OnMouseUp()
    {
        mouseUpEvent.Invoke();
    }

    private void OnMouseExit()
    {
        mouseExitEvent.Invoke();
    }
    
    private void OnMouseEnter()
    {
        mouseEnterEvent.Invoke();
    }

    private void OnMouseDrag()
    {
        mouseDragEvent.Invoke();
    }

    private void OnMouseOver()
    {
        mouseOverEvent.Invoke();
    }
}