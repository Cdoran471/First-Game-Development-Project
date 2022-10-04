using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenuScript : MonoBehaviour
{
    public GameObject menu;
    public TextMeshProUGUI testingText;
    public KeyCode testingKey;
    public bool isPaused = false;
    void Start()
    {
        menu.SetActive(false);
        Time.timeScale = 1f;
    }


    void Update()
    {
        if (Input.GetKeyDown(testingKey))
        {
            testingText.text = "Down";
            testingText.color = Color.red;
            //Debug.Log("Down");
        }
        else if (Input.GetKey(testingKey))
        {
            testingText.text = "Hold";
            testingText.color = Color.magenta;
            //Debug.Log("Hold");
        }
        else if (Input.GetKeyUp(testingKey))
        {
            testingText.text = "Up";
            testingText.color = Color.yellow;
            //Debug.Log("Up");
        }
        
        if (Input.GetButtonDown("Cancel"))
        {
            TogglePauseGame();
        }
    }
    public void TogglePauseGame()
    {
        //menu.SetActive(true);

        isPaused = !isPaused;
        //menu.SetActive(!menu.activeInHierarchy);
        menu.SetActive(isPaused);

        if (isPaused)
        {
            Time.timeScale = 0f;
        }
        else
        {
            Time.timeScale = 1f;
        }
    }
    public void LoadLevel(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
