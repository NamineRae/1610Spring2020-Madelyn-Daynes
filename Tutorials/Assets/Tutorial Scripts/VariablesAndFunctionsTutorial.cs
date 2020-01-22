using UnityEngine;

public class VariablesAndFunctionsTutorial : MonoBehaviour
{
    private int myInt = 5;

    void Start()
    {
        myInt = MultiplyByTwo(myInt);
        Debug.Log(myInt);
    }

    int MultiplyByTwo(int number)
    {
        int ret;
        ret = number * 2;
        return ret;
    }
}
// This is from a Unity Learn Tutorial
/* this is a test
 of the multi line comment
 because I forgot
 how to do it
 but also to get the 25 lines of code*/
