using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("Level0");
    }

    public void GoToControlsMenu()
    {
        SceneManager.LoadScene("ControlsScreen");
    }

    public void GoToAboutMenu()
    {
        SceneManager.LoadScene("AboutScreen");
    }

    public void GoToMainMenu()
    {
        SceneManager.LoadScene("OpeningScreen");
    }

    public void QuitGame()
    {
        //Application.Quit();
        SceneManager.LoadScene("EndingScreen");
    }
}
