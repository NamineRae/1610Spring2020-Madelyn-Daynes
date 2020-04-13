using UnityEngine;

public class InventoryTutorial : MonoBehaviour
{
    public class Stuff
    {
        public int bullets;
        public int grenades;
        public int rockets;
        public float fuel;
        
        public Stuff(int bul, int gre, int roc, float fu)
        {
            bul = bullets;
            gre = grenades;
            roc = rockets;
            fu = fuel;
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