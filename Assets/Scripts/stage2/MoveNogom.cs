using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveNogom : MonoBehaviour
{
    private Rigidbody2D nogomRigidbody;     // 이동에 사용할 노곰 리지드 바디
    public float speed = 6f;              // 이동 속력

    Vector2 inputPosition;                  // 터치 부분의 위치를 받을 변수
    Camera MainCamera;                      // Main Camera를 할당받을 변수

    void Start()
    {
        nogomRigidbody = GetComponent<Rigidbody2D>();                           // Rigidbody 할당
        MainCamera = GameObject.Find("Main Camera").GetComponent<Camera>();     // Main Camera 할당
    }

    void Update()
    {
        // 화면의 왼쪽을 터치하면 xIput = -1.0, 오른쪽을 터치하면 xIput = 1.0, 그렇지 않으면 0
        float xInput = 0f;
        if (Input.GetMouseButton(0))
        {
            inputPosition = MainCamera.ScreenToWorldPoint(Input.mousePosition);     // 월드 좌표 중심으로 바꿔주기

            if (inputPosition.x > 0)
                xInput = 1.0f;
            else if (inputPosition.x < 0)
                xInput = -1.0f;
        }

        float xSpeed = xInput * speed;

        Vector2 newVelocity = new Vector2(xSpeed, 0f);
        nogomRigidbody.velocity = newVelocity;

    }

    public void Die()
    {
        gameObject.SetActive(false);
    }
}
