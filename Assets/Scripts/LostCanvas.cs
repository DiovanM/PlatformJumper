using UnityEngine;
using System.Collections;

public class LostCanvas : MonoBehaviour {
    private bool y = false;
    public GameObject canvas;
    public GameObject buttons;

    
	// Use this for initialization
	void Start () {
        buttons.SetActive(true);
        canvas.SetActive(false);
        DestroyBehaviourScott.x = false;
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        if (DestroyBehaviourScott.x == true && y == false)
        {
            canvas.SetActive(true);
            buttons.SetActive(false);
            Time.timeScale = 0;
            y = true;
        }

    }
}
