﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//NogomController는 플레이어 캐릭터로서 Nogom 게임 오브젝트를 제어한다.
public class NogomController : MonoBehaviour
{
    public float jumpForce = 1000f;
    
    public AudioClip deathClip;
    public static int heartCount = 3;

    private int jumpCount = 0; //노곰이가 두번 점프하면 0으로 리셋됨
    private bool isGrounded = false;
    private bool isDead = false; //떨어져서 데드존에 닿거나 장애물 세번 맞으면(하트 세번깎이면) 죽음
    

    private Animator animator;
    private Rigidbody2D nogomRigidbody;
    private AudioSource nogomAudio;

    // Start is called before the first frame update
    void Start()
    {
        // 초기화
        // nogom 게임 오브젝트로부터 사용할 컴포넌트들의 참조를 가져와 변수에 할당한다
        nogomRigidbody = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        nogomAudio = GetComponent<AudioSource>();
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

            // 소리 재생
            nogomAudio.Play();
        }
        else if (Input.GetMouseButtonUp(0) && nogomRigidbody.velocity.y > 0)
        {//마우스 왼쪽 버튼에서 손을 떼는 순간 노곰이가 위로 올라가고 있다면
         // 현재 속도를 절반으로 변경
            nogomRigidbody.velocity *= 0.5f;

        }

        animator.SetBool("Grounded", isGrounded);


    }
    private void Die() //사망 애니메이션 재생하고 노곰이의 현재 상태를 사망상태로 변경
    {
        // 애니메이터의 die 트리거 파라미터
        animator.SetTrigger("Die");

        //오디오 클립을 죽는 걸로 변경
        nogomAudio.clip = deathClip;

        // 사망 효과음
        nogomAudio.Play();

        // 속도를 없앰
        nogomRigidbody.velocity = Vector2.zero;

        //사망 상태를 true로 변경
        isDead = true;

        //게임 매니저의 게임오버 처리 실행
        GameManager3.instance.OnPlayerDead();
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Dead" && !isDead)
        {
            // 충돌한 상대방의 태그가 Dead이고 아직 사망하지 않았다면 죽음.
            Die();
        }
        if (other.tag == "Obstacle")
        {
            heartCount--;
            if(heartCount>=0) GameObject.Find("Life").GetComponent<Life>().HeartOff();

            if(heartCount <= 0)
            {
                Die();
            }

        }

        if (other.tag == "Coin")
        {
            other.gameObject.SetActive(false);
            GameManager3.instance.AddScore(10);
        }

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        // 어떤 콜라이더와 닿았으며, 충돌 표면이 위쪽을 보고 있으면
        if (collision.contacts[0].normal.y > 0.7f)
        {
            isGrounded = true;
            jumpCount = 0;
        }
        
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        //어떤 콜라이더에서 떼어진 경우
        isGrounded = false;
    }

   





}