using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void Play ()
    {
        SceneManager.LoadScene("InteriorShot");
    }

    public void Kill()
    {
        Debug.Log("This is a test for quitting.");
        Application.Quit();
    }
}
