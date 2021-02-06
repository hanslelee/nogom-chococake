using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum GameState
{
    Ready,
    Play,
    End
}

public class GameManager : MonoBehaviour
{
    public static GameManager manager;
    public int score;

    void Awake()
    {
        if (manager != null)
            Debug.Log("Game manager Warning: Mutiple instance is running");
        manager = this;
    }

    public void AddScore(int value)
    {
        score += value;
    }

    public void SetGameOver()
    {
        //게임 오버시 처리 코드
    }

    public void SetReplay()
    {
        //게임 재시작시 처리코드
    }
}
