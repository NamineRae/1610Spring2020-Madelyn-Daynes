using System;
using UnityEngine;

public class UsingOtherComponentsTutorial : MonoBehaviour
{
    public GameObject otherGameObject;

    private AnotherScriptTutorial anotherScript;
    private YetAnotherScriptTutorial yetAnotherScript;
    private BoxCollider boxCol;

    private void Awake()
    {
        anotherScript = GetComponent<AnotherScriptTutorial>();
        yetAnotherScript = otherGameObject.GetComponent<YetAnotherScriptTutorial>();
        boxCol = otherGameObject.GetComponent<BoxCollider>();
    }

    private void Start()
    {
        boxCol.size = new Vector3(3,3,3);
        Debug.Log("The player's score is " + anotherScript.playerScore);
        Debug.Log("The player has died " + yetAnotherScript.numberOfPlayerDeaths + " times");
    }
}
//unity learn tutorial