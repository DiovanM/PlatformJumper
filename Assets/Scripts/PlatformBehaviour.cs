using UnityEngine;
using System.Collections;

public class PlatformBehaviour : MonoBehaviour {
    


    // Use this for initialization
    void Start () {
        
	
	}
	
	// Update is called once per frame
	void Update () {
       
            transform.Translate(0, - Time.deltaTime * RandomInstantiate.speed , 0);
    }
}
