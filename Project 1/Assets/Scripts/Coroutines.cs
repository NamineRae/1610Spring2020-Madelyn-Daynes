﻿using System.Collections;
using UnityEngine;
using UnityEngine.Events;

public class Coroutines : MonoBehaviour
{
    public int counter = 3;
    public float seconds = 1f;
    public string message = "GO!";
    public IntData numberData;
    public UnityEvent startEvent, repeatEvent, endEvent;
    private WaitForSeconds waitObj;

    private IEnumerator Start()
   {
       waitObj = new WaitForSeconds(seconds);
       startEvent.Invoke();
       while (counter > 0)
       {
           numberData.value = counter;
           yield return waitObj;
           repeatEvent.Invoke();
           counter--;
       }
       yield return waitObj;
       endEvent.Invoke();

   }

}
