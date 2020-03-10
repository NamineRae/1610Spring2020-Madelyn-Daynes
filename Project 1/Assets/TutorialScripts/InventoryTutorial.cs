using UnityEngine;

public class InventoryTutorial : MonoBehaviour
{
    public class Stuff
    {
        public int bullets;
        public int grenades;
        public int rockets;
        public float fuel;
        
        public Stuff(int bul, int gre, int roc)
        {
            bullets = bullets;
            grenades = grenades;
            rockets = rockets;
        }
public Stuff(int bul, float fu)
{
    bullets = bullets;
    fuel = fuel;
}
public Stuff()
        {
            bullets = 1;
            grenades = 1;
            rockets = 1;
        }
    }
    public Stuff myStuff = new Stuff();
    
    public Stuff myOtherStuff = new Stuff();

    void Start()
    {
        Debug.Log(myStuff.bullets);
    }
}
//unity learn tutorial