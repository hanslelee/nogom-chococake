using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class LockManager : MonoBehaviour
{
    int stage1ClearLoaded = 0; // 지금까지 클리어한 스테이지
    int stage2ClearLoaded = 0;
    public static bool stage1Clear = false;
    public static bool stage2Clear = false;
    public GameObject stage2LockedScreen;
   // public GameObject stage2UnlockedScreen;
    public GameObject stage3LockedScreen;
   // public GameObject stage3UnlockedScreen;

    public void GameSave()
    {
        
    }

    public void GameLoad()
    {

    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!PlayerPrefs.HasKey(("stage1Clear")))
        {
            stage1ClearLoaded = 0;
        }
        if (!PlayerPrefs.HasKey(("stage2Clear")))
        {
            stage2ClearLoaded = 0;
        }
        stage1ClearLoaded = PlayerPrefs.GetInt("stage1Clear");
        stage2ClearLoaded = PlayerPrefs.GetInt("stage2Clear");
        if (stage1ClearLoaded == 1 )
        {
            stage2LockedScreen.SetActive(false);
            //stage2UnlockedScreen.SetActive(true);

        }
        if(stage2ClearLoaded == 1 )
        {
            stage3LockedScreen.SetActive(false);
           // stage3UnlockedScreen.SetActive(true);
        }
    }
}
