using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChangeToLobby : MonoBehaviour
{
    public void ToLobby()
    {
        //테스트
         // PlayerPrefs.DeleteAll();

        SceneManager.LoadScene("LOBBY");
    }
}
