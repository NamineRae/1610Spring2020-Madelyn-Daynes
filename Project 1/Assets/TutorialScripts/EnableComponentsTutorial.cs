using System;
using UnityEngine;
using System.Collections;
public class EnableComponentsTutorial : MonoBehaviour
{
   private Light myLight;

   private void Start()
   {
      myLight = GetComponent<Light>();
   }

   void Update()
   {
      if(Input.GetKeyUp(KeyCode.Space))
      {
      myLight.enabled = !myLight.enabled;
      }
   }
}
