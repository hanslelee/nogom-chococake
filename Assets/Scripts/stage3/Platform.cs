using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//발판으로서 필요한 동작을 담은 스크립트
public class Platform : MonoBehaviour
{
    public GameObject[] obstacles;
    private bool stepped = false;
    
    //컴포넌트가 활성화될 때마다 매번 실행되는 메서드
    private void OnEnable()
    {
        //발판을 리셋하는 처리
        stepped = false;

        //장애물 수만큼 루프
        for(int i = 0; i < obstacles.Length; i++)
        {
            //현재 순번의 장애물을 1/4의 확률로 활성화
            if (Random.Range(0, 4) == 0)
            {
                obstacles[i].SetActive(true);
            }
            else
            {
                obstacles[i].SetActive(false);
            }
        }
        

    }
    

}
