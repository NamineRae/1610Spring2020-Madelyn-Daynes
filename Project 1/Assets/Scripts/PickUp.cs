using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
   public enum PickUpTypes
   {
      COIN,
      HEALTH,
      POWERUP 
   }

   public PickUpTypes PickUpType;

   private void OnTriggerEnter(Collider other)
   {
      if (PickUpType == PickUpTypes.COIN)
      {
         CoinManager CM = GameObject.Find("CoinManager").GetComponent<CoinManager>();
         CM.CoinCounter.ChangeValue(1);
      }

      if (PickUpType == PickUpTypes.HEALTH)
      {
         //hi
      }

      if (PickUpType == PickUpTypes.POWERUP)
      {
         //hi
      }
      Destroy(gameObject);
   }
}
