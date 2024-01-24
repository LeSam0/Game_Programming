using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject EnnemyBas;
    public GameObject EnnemyHaut;
    public GameObject Piece;
    private static System.Random random = new System.Random();
    bool randomBoolean = random.Next(2) == 0;

    void Start()
    {
        float speed = 0.0f;
        InvokeRepeating("Spawn", speed+ Time.deltaTime, 1.0f);
        InvokeRepeating("Spawn_Piece", speed+ Time.deltaTime, 3.0f);

    }

    void Spawn() 
    {    
        if (randomBoolean) {
            Vector2 pos1 = new Vector2(11, -4.5f);
            Instantiate(EnnemyBas, pos1, Quaternion.identity);
        } else {
            Vector2 pos1 = new Vector2(11, -1.5f);
            Instantiate(EnnemyHaut, pos1, Quaternion.identity); 
        }
        randomBoolean = random.Next(2) == 0;
    }

    void Spawn_Piece() 
    {    
            float position = Random.Range(0f, -1.5f);
            Vector2 pos1 = new Vector2(11, position);
            Instantiate(Piece, pos1, Quaternion.identity); 
    }
}
