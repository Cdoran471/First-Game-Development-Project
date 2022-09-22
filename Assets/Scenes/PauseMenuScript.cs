using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenuScript : MonoBehaviour
{
    // The header of a function NEVER has a semicolon in it
    // This function takes no arguments/parameter but you must still include the paratheses!
    public void ExitGame()
    {
        Debug.Log("Quitted");
        Application.Quit();
    }// { must have a } to match it

    public void LoadLevel(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
