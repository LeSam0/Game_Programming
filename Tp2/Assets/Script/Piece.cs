using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;

public class Piece : MonoBehaviour 
{
    public int speed;
    void Update()
    {
       Vector2 movement = new Vector2(-1 ,0);
        transform.Translate(movement * Time.deltaTime * speed);
    }

    private void OnTriggerStay2D(Collider2D Piece)
    { 
        if (Piece.gameObject.tag == "Mur") {
            Destroy(this.gameObject);
            
        }

        if (Piece.gameObject.tag == "Player") {
            Destroy(this.gameObject);
            Score.timeRemaining += 1;
        }
    }


}
