using UnityEngine;
using System.Collections;

public class InstantiateAlien : MonoBehaviour {
    private float time = 0;
    public GameObject alien;
    private int x =0;
	// Use this for initialization
		
	// Update is called once per frame
	void Update () {
        time += Time.deltaTime;
        if (time >= 30 && x==0)
        {
            Instantiate(alien);
            x++;
        }

    }
    
}
