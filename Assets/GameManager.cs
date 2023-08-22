using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
    }

    public void Quitapp()
    {
        Application.Quit();
    }

    public void PlayGame()
    {
        SceneManager.LoadScene("Game");
    }

    public void EndGame()
    {
        SceneManager.LoadScene("End");
    }
}
