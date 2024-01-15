using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using UnityEngine;
using UnityEngine.SceneManagement;

public class deplacement : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        float moveX = Input.GetAxis("Horizontal");
        float moveY = Input.GetAxis("Vertical");
        float speed = 20;
        Vector2 movement = new Vector2(moveX, moveY);

        transform.Translate(movement * Time.deltaTime * speed);
    }

    private void OnCollisionEnter2D(Collision2D asteroid)
    {   
        if (asteroid.gameObject.tag == "meteor")
            SceneManager.LoadScene("GAME_OVER");
    }    
}
