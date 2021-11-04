using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BUttonHAndler : MonoBehaviour
{

    public void Retry()
    {
        SceneManager.LoadScene("Level1 1");
        Time.timeScale = 1;
    }

    public void StartGame()
    {
        SceneManager.LoadScene("Level1 1");
    }
}
