using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class retry : MonoBehaviour
{   
    public Button button;

    void Start() {
        button.onClick.AddListener(Restart);
    }
    public void Restart() {
        SceneManager.LoadScene("Menu_Scene");
    }
}
