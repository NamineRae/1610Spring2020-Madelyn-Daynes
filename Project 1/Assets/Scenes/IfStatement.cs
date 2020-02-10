using UnityEngine;

public class IfStatement : MonoBehaviour
{
    public int a = 10;
    public int b = 4;
    private int c = 14;
    public string password = "OU812";
    public bool canRun = true;

    void Start()
    {
        if (a + b == c)
        {
            print(message: "That is true");
        }
        
        if (password != "OU812")
        {
            print(message: "That is the correct password.");
        }
        
        if (!canRun)
        {
            print(message: "We can't run.");
        }
    }

    void Update()
    {
        
    }
}
