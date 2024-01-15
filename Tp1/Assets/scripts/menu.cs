using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Jouer : MonoBehaviour
{
    public void Game() {
        SceneManager.LoadScene("MAIN_SCENE");
    }
    public void Quitter() {
        Application.Quit();
    }
}
