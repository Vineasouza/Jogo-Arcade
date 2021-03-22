using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scriptMenu : MonoBehaviour
{
    private bool menuON = false;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {   
            if (!menuON)
            {
                Time.timeScale = 0;
                SceneManager.LoadSceneAsync(0, LoadSceneMode.Additive);
            } else
            {
                Time.timeScale = 1;
                SceneManager.UnloadSceneAsync(0);
            }

            menuON = !menuON;
        }
    }
}
