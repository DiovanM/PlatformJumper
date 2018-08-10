using UnityEngine;
using System.Collections;
using UnityEngine.Audio;

public class Pausesong : MonoBehaviour {
    public AudioSource song;
    private bool pausesong;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Pause.pause2 == true)
        {
            Pause.pausesong = false;
            pausesong = true;
          song.Pause();
        }
        else if (Pause.pause2 == false && pausesong)
        {
            Pause.pausesong = true;
            pausesong = false;
            song.Play();
            Debug.Log("a");
        }
	
	}
}
