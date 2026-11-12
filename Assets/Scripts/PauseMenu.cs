using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Events;
using System.Collections;
using UnityEngine.EventSystems;

public class PauseMenu : MonoBehaviour

{
 
    //[SerializeField] GameObject pauseMenu;
    public GameObject pauseMenu;
 
    private bool isPaused = false;
 
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
   
    }
 
    public void Pause()
    {
        pauseMenu.SetActive(true);
        Time.timeScale = 0;
 
        isPaused = true;
 
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;

        pauseMenu.gameObject.SetActive(!pauseMenu.gameObject.activeSelf);
    }
 
    public void Home()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1;
 
        isPaused = true;
 
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }
 
    public void Resume()
    {
        pauseMenu.SetActive(false);
        Time.timeScale = 1;
 
        isPaused = false;
 
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }
 
    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1;
 
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }
}

