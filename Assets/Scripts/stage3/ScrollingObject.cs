﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollingObject : MonoBehaviour
{
    public float speed = 5f;


    // Update is called once per frame
    void Update()
    {
        //초당 9f만큼 왼쪽으로 이동
       // transform.Translate(Vector3.left * speed * Time.deltaTime);
        //Vector3.left = (-1,0,0)임
    }
}
