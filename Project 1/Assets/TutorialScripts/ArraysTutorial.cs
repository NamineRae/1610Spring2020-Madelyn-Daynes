using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArraysTutorial : MonoBehaviour
{
    public GameObject[] players;

    void Start()
    {
        players = GameObject.FindGameObjectsWithTag("Player");
        for (int i = 0; i < players.Length; i++)
        {
            Debug.Log("Player Number " + i + " is named " + players[i].name);
        }
    }
}
//unity learn tutorial
