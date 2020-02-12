using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewClass : MonoBehaviour
{ 
    public string nameString;

    public int intNum;

    public float floatnum;

    public GameObject gameobj;
    
    // Start is called before the first frame update
    void Start()
    {
        print(nameString);
        print(intNum);
        print(floatnum);
        print(gameobj);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
