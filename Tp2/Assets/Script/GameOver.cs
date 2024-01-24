using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;


public class GameOver : MonoBehaviour
{
    public static float score;
    void Start(){
        
        score = Score.timeRemaining; 
        startText.text = $"Score : {Mathf.FloorToInt(score*10)}";
    }
    public Text startText;
}