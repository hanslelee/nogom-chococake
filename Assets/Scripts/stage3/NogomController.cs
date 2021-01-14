using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//NogomController는 플레이어 캐릭터로서 Nogom 게임 오브젝트를 제어한다.
public class NogomController : MonoBehaviour
{
    public float jumpForce = 700f;

    private int jumpCount = 0; //노곰이가 두번 점프하면 0으로 리셋됨
    private bool isGrounded = false;
    private bool isDead = false; //떨어져서 데드존에 닿거나 장애물 세번 맞으면(하트 세번깎이면) 죽음

    private Animator animator;
    private Rigidbody2D nogomRigidbody;

    // Start is called before the first frame update
    void Start()
    {
        // 초기화
        // nogom 게임 오브젝트로부터 사용할 컴포넌트들의 참조를 가져와 변수에 할당한다
        nogomRigidbody = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        // 점프
        if (isDead)
        {
            // 사망했으면 종료
            return;
        }
        
        
        if(Input.GetMouseButtonDown(0) && jumpCount < 2)
        {//마우스 왼쪽 버튼 누를때

            jumpCount++;

            // 직전 속도에 영향을 받지 않도록 순간적으로 속도 (0,0)으로 만들고 위로 jumpForce만큼 힘주기
            nogomRigidbody.velocity = Vector2.zero;
            nogomRigidbody.AddForce(new Vector2(0, jumpForce));
        }
        else if (Input.GetMouseButtonUp(0) && nogomRigidbody.velocity.y > 0)
        {//마우스 왼쪽 버튼에서 손을 떼는 순간 노곰이가 위로 올라가고 있다면
         // 현재 속도를 절반으로 변경
            nogomRigidbody.velocity *= 0.5f;

        }

        animator.SetBool("Grounded", isGrounded);


    }
}