using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Movement : MonoBehaviour
{

public Rigidbody2D rb;
public float jumpAmount = 10;
int numberjump = 2;
int Jumpultime = 0;
void Update()
{
    int time = Random.Range(0,1000000);

    if (time == 10 && time != 0 && Jumpultime == 0) {
        jumpAmount = 30;
    }
    if (Input.GetKeyDown(KeyCode.Space))
    {
        if (numberjump > 0) {
        numberjump = numberjump -1 ;
        rb.AddForce(Vector2.up * jumpAmount, ForceMode2D.Impulse);
            if (Jumpultime == 0 && jumpAmount == 30) {
                Jumpultime = 1;
            } 
        }
    }
    if (Jumpultime == 1 && jumpAmount == 30) {
        Jumpultime = 0;
        jumpAmount = 10;
    } 


}
private void OnCollisionEnter2D(Collision2D MovementBlock)
    { 
        if (MovementBlock.gameObject.tag == "Sol") {
            numberjump = 2;
        }

        if (MovementBlock.gameObject.tag == "Ennemy") {
            SceneManager.LoadScene("GameOver");
        }
}
}


