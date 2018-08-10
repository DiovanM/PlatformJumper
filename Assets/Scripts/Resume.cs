using UnityEngine;
using System.Collections;

public class Resume : Pause {

    // Use this for initialization
	public void Resumegame()
    {
        canvas.SetActive(false);
        controls.SetActive(true);
        Time.timeScale = 1;
        pause = false; 
    }
}
