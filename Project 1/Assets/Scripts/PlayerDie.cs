using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerDie : MonoBehaviour
{
    public UnityEvent PlayerDeath;
    public UnityEvent PlayerRespawn; 
    public FloatData HealthFloatData;
    void Update()
    {
        if (HealthFloatData.value <= 0)
        {
            PlayerDeath.Invoke();
            StartCoroutine("Delay");
        }
    }

    IEnumerator Delay()
    {
        yield return new WaitForSeconds(0.05f);
        PlayerRespawn.Invoke();
    }
}
//got help writing this from classmate