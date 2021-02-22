using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameStart2 : MonoBehaviour
{
    public bool gameStarted2 = false;
    public GameObject explanationUI;
    public GameObject gameStartButtonUI;

    int helpForTheFirstTime = 0;

    // Start is called before the first frame update
    void Start()
    {
        if (PlayerPrefs.HasKey("stage2Open"))
        {
            helpForTheFirstTime = PlayerPrefs.GetInt("stage2Open");
        }
        if (helpForTheFirstTime == 1)
        {
            // 이미 게임을 시작한 적이 있다면
            explanationUI.SetActive(false);
            gameStartButtonUI.SetActive(true);
        }
        else
        {
            helpForTheFirstTime = 1;
            PlayerPrefs.SetInt("stage2Open", 1);
        }
    }



    // Update is called once per frame
    void Update()
    {
        if (!gameStarted2 && Input.GetMouseButtonDown(0))
        {
            explanationUI.SetActive(false);
            gameStartButtonUI.SetActive(true);


        }
    }


    public void startGame2()
    {
        if (!gameStarted2 && Input.GetMouseButtonDown(0))
        {
            startGame2();
            gameStarted2 = true;
        }
        SceneManager.LoadScene("STAGE2");
    }
}
