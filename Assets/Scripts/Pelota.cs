﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pelota : MonoBehaviour
{


    public Transform paddle;
    bool gameStarted = false;

    public Rigidbody2D rbBall;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(!gameStarted)
        {
            float posDif = paddle.position.x - transform.position.x;
            transform.position = new Vector3(paddle.position.x - posDif, paddle.position.y, paddle.position.z);

            if(Input.GetMouseButtonDown(0))
            {
                rbBall.velocity = new Vector2(8,8);
                gameStarted = true;                    
            }
        }
    }
}
