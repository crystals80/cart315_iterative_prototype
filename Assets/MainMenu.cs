using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        // Trigger the game at Level 0 
        SceneManager.LoadScene("Level0");
    }

    public void GoToControlsMenu()
    {
        // Trigger the control screen
        SceneManager.LoadScene("ControlsScreen");
    }

    public void GoToAboutMenu()
    {
        // Trigger the about screen
        SceneManager.LoadScene("AboutScreen");
    }

    public void GoToMainMenu()
    {
        // Trigger the opening screen
        SceneManager.LoadScene("OpeningScreen");
    }

    public void QuitGame()
    {
        //Application.Quit(); // End the game
        // Trigger the ending screen
        SceneManager.LoadScene("EndingScreen");
    }
}
