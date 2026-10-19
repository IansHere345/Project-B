using UnityEngine;
using UnityEngine.SceneManagement;

public class pauseMenuScript : MonoBehaviour
{
    public GameObject pauseMenu;
    public bool isPaused;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        pauseMenu.SetActive(false); //pause menu is diabled at the start
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape)) //The esc key controls if the game is paused
        {
            if(isPaused)
            {
                ResumeGame();
            }
            else
            {
                PauseGame();
            }
        }
    }
    public void PauseGame()
    {
        pauseMenu.SetActive(true);
        Time.timeScale = 0f; //time runs at 0% speed
        isPaused = true;
    }
        public void ResumeGame()
    {
        pauseMenu.SetActive(false);
        Time.timeScale = 1f; //time runs at 100% speed
        isPaused = false;
    }
    //Source Used: https://www.youtube.com/watch?v=9dYDBomQpBQ&t=347s
}
