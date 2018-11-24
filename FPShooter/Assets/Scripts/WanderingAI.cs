using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WanderingAI : MonoBehaviour {

    public float speed = 3.0f;//значение скорости движения и расстояния

    public float obstacleRange = 5.0f;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
            transform.Translate(0, 0, speed * Time.deltaTime);//непрерывно движемся вперед в каждом кадре
    }

}
