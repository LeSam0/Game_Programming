using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;

public class Ennemy : MonoBehaviour 
{
    public int speed;
    void Update()
    {
       Vector2 movement = new Vector2(-1 ,0);
        transform.Translate(movement * Time.deltaTime * speed);
    }

    private void OnCollisionEnter2D(Collision2D MovementBlock)
    { 
        if (MovementBlock.gameObject.tag == "Mur") {
            Destroy(this.gameObject);
            
        }
    }
}
