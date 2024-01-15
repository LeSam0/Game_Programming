using System.Collections;
using System.Collections.Generic;
using System.Data.Common;
using JetBrains.Annotations;
using UnityEngine;

public class aparition : MonoBehaviour
{
    public GameObject Asteroid_1;
    public GameObject Asteroid_2;
    public GameObject Asteroid_3;
    public GameObject Asteroid_4;
    void Start()
    {
        float speed = 0.0f;
        InvokeRepeating("Spawn", speed+ Time.deltaTime, 1.0f);
       
    }
    void Spawn()
    {    
        float position = Random.Range(10.9f, -10.9f);
        Vector2 pos = new Vector2(position, 4.8f);
        Instantiate(Asteroid_1, pos, Quaternion.identity);

        float position1 = Random.Range(-4.9f, 4.9f);
        Vector2 pos1 = new Vector2(-10.8f, position1);
        Instantiate(Asteroid_2, pos1, Quaternion.identity);

        float position2 = Random.Range(-4.9f, 4.9f);
        Vector2 pos2 = new Vector2(10.8f, position2);
        Instantiate(Asteroid_3, pos2, Quaternion.identity);

        float position3 = Random.Range(10.9f, -10.9f);
        Vector2 pos3 = new Vector2(position3, -4.8f);
        Instantiate(Asteroid_4, pos3, Quaternion.identity);
    }
}
