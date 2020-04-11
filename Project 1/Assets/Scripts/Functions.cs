using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class Functions : MonoBehaviour
{
    public void Add(int a, int b)
    {
        int c = a + b;
        print(c);
    }

    public int AddWithReturn(int a, int b)
    {
        return a + b;
    }

    void Start()
    {
        int c = AddWithReturn(7, 2);
        Add(9, 7);
    }
}