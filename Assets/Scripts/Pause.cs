using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour {
    public bool pause = false;
    public static bool pause2;
    public GameObject canvas;
    public GameObject controls;
    public static bool pausesong;


	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Pausegame();
        }
	
	}
    public void Pausegame()
    {
        if (pause == false && DestroyBehaviourScott.x == false)
        { 
            canvas.SetActive(true);
            controls.SetActive(false);
            Time.timeScale = 0;
            pause = true;
            pause2 = true;
        }
        else if(pause == true && DestroyBehaviourScott.x == false)
        {
            canvas.SetActive(false);
            controls.SetActive(true);
            Time.timeScale = 1;
            pause = false;
            pause2 = false;
        }
    }
    
   
}
