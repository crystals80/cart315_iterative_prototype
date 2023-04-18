using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class win : MonoBehaviour
{
    // Variable for reaching the finish platform and moving to the next level
    public GameObject Player;
    public GameObject GameManagerInstance;
    public int currentLevel;
    private int switchCurrentLevel;

    void Start()
    {
        // Find the game object called GameManager
        GameManagerInstance = GameObject.Find("GameManager");
        // Set the current level as the one from the GameManagerScript
        currentLevel = GameManagerInstance.GetComponent<GameManagerScript>().level;
        Debug.Log("Level in trigger script" + currentLevel);
    }

    // On collision to an obstacle
    void OnCollisionEnter()
    {
        // ...trigger the sound effect dedicated to it...
        GetComponent<AudioSource>().Play();
        // and run the Reload funtion after a delay of 2 frames
        Invoke("Reload", 2f);
    }

    void Reload()
    {
        // Switch level by adding 1 to its integer (Level 0 to Level 1 to Level 2, etc)
        switchCurrentLevel = currentLevel + 1;
        // Set the level switch as a new level/scene
        GameManagerInstance.GetComponent<GameManagerScript>().SetNewLevel();
        // Load the new level/scene
        SceneManager.LoadScene("Level" + switchCurrentLevel);

    }
}