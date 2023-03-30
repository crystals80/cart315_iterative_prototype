using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerScript : MonoBehaviour
{
    public int level = 0;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(level);
    }

    void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }

    public void SetNewLevel()
    {
        level = level + 1;
    }


}
