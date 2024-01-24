using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    void Start(){
        startText.text = "Score : 0";
        timeRemaining = 0;
    }
    public Text startText;
    public static float timeRemaining = 0;
    void Update()
    {
        timeRemaining += Time.deltaTime;
        startText.text=$"Score : { Mathf.FloorToInt(timeRemaining*10) }";
    }
}
