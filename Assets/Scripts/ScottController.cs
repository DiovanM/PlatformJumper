using UnityEngine;
using System.Collections;
using UnityStandardAssets.CrossPlatformInput;

public class ScottController : MonoBehaviour {

    protected Controller controller;

	// Use this for initialization
	void Start () {
        controller = GetComponent<Controller>();
	
	}
	
	// Update is called once per frame
	void Update () {
        controller.SetSpeed(CrossPlatformInputManager.GetAxis("Horizontal"));
        if (Input.GetButtonDown("Jump"))
        {
            controller.Jump();
        }
	
	}

}
