﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerDeath : MonoBehaviour
{
    public UnityEvent PlayerDeath;
    public FloatData HealthFloatData;
    void Update()
    {
        if (HealthFloatData.value <= 0)
        {
            PlayerDeath.Invoke();
        }
    }
}
