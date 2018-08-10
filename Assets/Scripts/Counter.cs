using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Counter : MonoBehaviour {
    private float timer = 0;
   
    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        timer += Time.deltaTime;
                  
        GetComponent<Text>().text = "" + Mathf.Floor(timer);
        }

    }

