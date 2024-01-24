using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menu : MonoBehaviour
{
    // Start is called before the first frame update
   public void Game()
    {
        SceneManager.LoadScene("SampleScene");

    }

    // Update is called once per frame
    public void Quitter()
    {
        Application.Quit();
    }

    public void Retry()
    {
        SceneManager.LoadScene("MenuJouer");
        Score.timeRemaining = 0;
    }
}
