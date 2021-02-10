using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager2 : MonoBehaviour
{
    public static GameManager2 instance;    // 싱글턴을 할당할 전역변수

    public bool isGameover = false;         // 게임 오버 상태
    public GameObject gameoverUI;           // 게임 오버시 활성화할 UI

    public int n_needle = 0, n_thread = 0, n_fabric = 0;    // 바늘, 실, 천 개수 
    
    void Awake()
    {
        if (instance == null)
            instance = this;
        else
        {
            Debug.LogWarning("씬에 두개 이상의 게임 매니저가 존재");
            Destroy(gameObject);
        }
    }

    public void OnPlayerDead()
    {
        isGameover = true;
        gameoverUI.SetActive(true);
    }
    
    void Start()
    {
        
    }

    void Update()
    {
        if(isGameover && Input.GetMouseButtonDown(0))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
