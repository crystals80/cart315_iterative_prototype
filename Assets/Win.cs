using UnityEngine;
using UnityEngine.SceneManagement;

public class win : MonoBehaviour
{
    public GameObject Player;
    public GameObject GameManagerInstance;
    public int currentLevel;
    private int switchCurrentLevel;

    void Start()
    {
        GameManagerInstance = GameObject.Find("GameManager");
        currentLevel = GameManagerInstance.GetComponent<GameManagerScript>().level;
        Debug.Log("Level in trigger script" + currentLevel);
    }

    void OnCollisionEnter()
    {
        GetComponent<AudioSource>().Play();
        Invoke("Reload", 2f);
    }

    void Reload()
    {
        switchCurrentLevel = currentLevel + 1;
        GameManagerInstance.GetComponent<GameManagerScript>().SetNewLevel();
        SceneManager.LoadScene("Level" + switchCurrentLevel);
    }

    /*void RestartPreviousScene()
    {
        //GetComponent<AudioSource>().Play();
        Invoke("ReloadPrevious", 2f);
    }

    void ReloadPrevious()
    {
        switchCurrentLevel = currentLevel - 1;
        GameManagerInstance.GetComponent<GameManagerScript>().SetNewLevel();
        SceneManager.LoadScene("Level" + switchCurrentLevel);
    }*/

}