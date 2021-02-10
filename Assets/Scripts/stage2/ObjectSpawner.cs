using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    // 생성할 오브젝트들의 원본 프리팹
    public GameObject needlePrefab, b_needlePrefab, threadPrefab, b_threadPrefab, fabricPrefab, b_fabricPrefab, bombPrefab;

    public float timeBetSpawnMin = 1.25f, timeBetSpawnMax = 2.25f;  // 다음 배치까지 시간 간격 최소, 최대값
    private float timeBetSpawn;                                     // 다음 배치까지의 시간 간격

    public float xMin = -8.5f, xMax = 8.5f;     // 배치할 위치의 최소, 최대 x값
    private float yPos = 7f;                    // 배치할 위치의 y값

    void Start()
    {
        
    }

    void Update()
    {
        // 게임 오버 상태에는 작동x
        if (GameManager2.instance.isGameover)
            return;

    }
}
