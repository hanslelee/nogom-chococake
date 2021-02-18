using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public enum GameState
{
    Ready,
    Play,
    End
}

public class Game_manager : MonoBehaviour
{
    public GameState Gs;

    //public bool isGameover = false; 
    //public bool isSuccess = false;
    public GameObject gameoverUI;
    public GameObject successImage;
    public GameObject toTheLobbyButton;
    public GameObject cleanNogomImage;
    public GameObject canvas;

    public dda_gauge dg;

    void Update()
    {
        if(Gs == GameState.Play)
        {
            if (dg.isSuccess == true)
            {
                Success();
            }
            else if(dg.isGameover == true)
            {
                End();
            }
        }
    }

    public void G0()
    {
        Gs = GameState.Play;
    }

    public void End()
    {
        Gs = GameState.End;
        gameoverUI.SetActive(true);
    }

    public void Success()
    {
        Gs = GameState.End;
        canvas.SetActive(false);
        successImage.SetActive(true);
        toTheLobbyButton.SetActive(true);
    }

    public void toTheLobbyScene()
    {
        SceneManager.LoadScene("LOBBY");
    }
}
