using UnityEngine;

public class DestroyOtherTutorial : MonoBehaviour
{
    public GameObject other;
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            Destroy(other);
        }
    }
}
//from unity learn tutorial