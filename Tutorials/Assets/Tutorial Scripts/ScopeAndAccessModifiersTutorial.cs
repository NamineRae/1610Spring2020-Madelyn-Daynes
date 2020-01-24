using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScopeAndAccessModifiersTutorials : MonoBehaviour
{
    public int alpha = 5;
    
    private int beta = 0;
    private int gamma = 5;

    private AnotherClassTutorial myOtherClass;
    
    void Start()
    {
        alpha = 29;
        
        myOtherClass = new AnotherClassTutorial();
        myOtherClass.FruitMachine(alpha, myOtherClass.apples);
    }

    void Example(int pens, int crayons)
    {
        int answer;
        answer = pens * crayons * alpha;
        Debug.Log(answer);
    }
    
    
    void Update()
    {
        Debug.Log("Alpha is set to: " + alpha);
    }
}
//Unity learn tutorial. This doesn't work for some reason and I have no idea how to fix it.