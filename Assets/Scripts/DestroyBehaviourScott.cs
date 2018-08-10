using UnityEngine;
using System.Collections;

public class DestroyBehaviourScott : MonoBehaviour {

    public static bool x = false;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Destroyer"))
        {
            Destroy(gameObject);
            x = true;
        }
    }
        
    void FixedUpdate()
    {



    }
}
