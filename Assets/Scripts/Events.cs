using UnityEngine;
using UnityEngine.Events;
using System.Collections;
using UnityEngine.SceneManagement;

public class Events : MonoBehaviour
{

    // Use this for initialization
    public void LoadLevel()
    {
        SceneManager.LoadScene("Cena1");
        Time.timeScale = 1;
    }
    public void LoadMenu()
    {
        SceneManager.LoadScene("Menu");
         
    }
    public void Exit()
    {
        Application.Quit();
    }
    


}

