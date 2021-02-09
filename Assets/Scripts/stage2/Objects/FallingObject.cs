using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingObject : MonoBehaviour
{
    void Start()
    {
        // 3초 뒤 자신의 게임 오브젝트 파괴
        Destroy(gameObject, 3f);
    }

    // 충돌 시 호출
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            gameObject.SetActive(false);

            nogomControllerStage2 nogomController = other.GetComponent<nogomControllerStage2>();

            if (nogomController != null)
            {
                getObject(nogomController);
            }
        }
    }

   virtual public void getObject(nogomControllerStage2 nogomController) {}
}
