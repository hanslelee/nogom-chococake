using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nogomControllerStage2 : MonoBehaviour
{
    Vector2 nogomPos;  // nogom's position
    float moveSpeed = 0.03f;

    void Start()
    {
        nogomPos = transform.position;
    }

    void Update()
    {
        if(Input.touchCount>0&&Input.GetTouch(0).phase==TouchPhase.Moved)
        {
            float dist = transform.position.y - Camera.main.transform.position.y;
        }
    }
}
