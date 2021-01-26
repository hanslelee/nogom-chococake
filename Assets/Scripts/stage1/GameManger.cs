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
    public GameState GS;
    public Hole[] hole;

    public GameObject ReadyGut;
}
