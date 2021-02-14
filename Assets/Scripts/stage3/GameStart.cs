using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameStart : MonoBehaviour
{
    public bool gameStarted = false;
    public GameObject explanationUI;
    public GameObject gameStartButtonUI;

    // Start is called before the first frame update
    void Start()
    {
        
    }

   

    // Update is called once per frame
    void Update()
    {
        if (!gameStarted && Input.GetMouseButtonDown(0))
        {
            explanationUI.SetActive(false);
            gameStartButtonUI.SetActive(true);

            
        }
    }

    
    public void startGame()
    {
        if (!gameStarted && Input.GetMouseButtonDown(0))
            {
                startGame();
                gameStarted=true;
            }
        SceneManager.LoadScene("STAGE3");
    }
}
