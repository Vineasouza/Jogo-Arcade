using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scriptJogo : MonoBehaviour
{
    // Start is called before the first frame update
    public void carregar(){
        Time.timeScale = 1;
        SceneManager.LoadScene(1);
    }

    public void sair()
    {
        Application.Quit();
    }
}
