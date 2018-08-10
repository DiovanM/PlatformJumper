using UnityEngine;
using System.Collections;

public class AlienBehaviour : MonoBehaviour {
    private float time = 0;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        time += Time.deltaTime;
        if (time >= 12)
        {
            Destroy(gameObject);
        }
            transform.Translate(Time.deltaTime*2, 0, 0);


    }
}
