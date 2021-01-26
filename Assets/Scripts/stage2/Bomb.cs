using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb : MonoBehaviour
{
    void Start()
    {
        // 3초 뒤 자신의 게임 오브젝트 파괴
        Destroy(gameObject, 3f);
    }

    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.tag=="Player")
        {
            nogomControllerStage2 nogomController = GetComponent<nogomControllerStage2>();

            if(nogomController!=null)
            {
                nogomController.life--;
            }
        }
    }
}
