using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void PauseGame ()
    {
        if (Time.timeScale == 0) {
            Time.timeScale = 1;
        } else {
            Time.timeScale = 0;
        }
    }

    // Update is called once per frame
    void Update()
    {
    if (Input.GetKeyDown(KeyCode.P) && Time.timeScale == 1) {
            Time.timeScale = 0;
    } else if (Input.GetKeyDown(KeyCode.P) && Time.timeScale == 0) {
        Time.timeScale = 1;
    }
    }
}
