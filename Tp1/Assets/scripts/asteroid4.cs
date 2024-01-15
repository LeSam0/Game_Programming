using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

public class Asteroid_4 : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D asteroid)
    { 
        if (asteroid.gameObject.tag == "mur") 
           Destroy(this.gameObject);

    }   
    void Update()
    {
        Vector2 movement = new Vector2(1 ,0);
        transform.Translate(movement * Time.deltaTime * 10);
    }
}
