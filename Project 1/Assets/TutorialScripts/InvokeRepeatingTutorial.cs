﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvokeRepeatingTutorial : MonoBehaviour
{
    public GameObject target;
    void Start()
    {
        InvokeRepeating("SpawnObject", 2, 1);
    }

    void SpawnObject()
    {
        float x = Random.Range(-2.0f, 2.0f);
        float z = Random.Range(-2.0f, 2.0f);
        Instantiate(target, new Vector3(x, 2, z), Quaternion.identity);
    }
}
//unity learn tutorial