using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManagerScript : MonoBehaviour
{
    // Variable for level management
    public int level = 0;
    public int prevLevel = 0;

    // Variables for health system
    public int health; // ...indicating the total number of life that the first controller has
    public int numOfHearts; // ...indication the number of heart to display

    public Image[] hearts; // ...creating an array for heart images
    public Sprite fullHeart; // ...creating sprites for a full life (with a filled heart shape)
    public Sprite emptyHeart; // ...creating sprited for an empty life (with an empty heart shape)

    public GameObject canvas;

    // Start is called before the first frame update
    void Start()
    {
        // Run UpdateHealth function
        UpdateHealth();
    }

    // Update is called once per frame
    void Update()
    {
        // Show which level the player is on in the game (only in console)
        Debug.Log(level);
        if (prevLevel != level)
        {
            Debug.Log("herer");
            prevLevel = level;
            for (int i = 0; i < hearts.Length; i++)
            {

                Debug.Log(hearts[i].sprite);
            }
        }
    }

    void Awake()
    {
        // Maintain the game object that has this script in the desired scenes (for level management)
        DontDestroyOnLoad(this.gameObject);
        canvas = GameObject.Find("Canvas Hearts");
        DontDestroyOnLoad(canvas);

    }

    public void SetNewLevel()
    {
        // Set a new level (Level 0 to Level 1 to Level 2, etc)
        level = level + 1;
        

    }

    public void UpdateHealth()
    {
        // If the health line is at 0 (no more full hearts)...
        if (health <= 0)
        {
            // ...trigger the sound effect dedicated to it...
            //GetComponent<AudioSource>().Play();
            // ...and restart the current scene/level by calling the Reload function after a delay of 1 frame 
            Invoke("Reload", 1f);
        }

        // Set up the number of hearts to be available to edit in Unity
        if (health > numOfHearts)
        {
            health = numOfHearts;
        }

        // Set up the images of empty/full hearts as sprites...
        for (int i = 0; i < hearts.Length; i++)
        {
            if (i < health)
            {
                hearts[i].sprite = fullHeart;
            }
            else
            {
                hearts[i].sprite = emptyHeart;
            }

            // ...and display them according to the damage control
            if (i < numOfHearts)
            {
                hearts[i].enabled = true;
            }
            else
            {
                hearts[i].enabled = false;
            }
        }
    }

    void Reload()
    {
        // To restart the current level, reload the scene
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
