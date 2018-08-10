using UnityEngine;
using System.Collections;

public class DestroyBehaviour : MonoBehaviour {

        
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Destroyer"))
        {
            Destroy(gameObject);            
        }
    }
    	
	// Update is called once per frame
	void FixedUpdate () {
        
	
	}
}
