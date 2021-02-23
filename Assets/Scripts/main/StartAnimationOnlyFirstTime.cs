using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class StartAnimationOnlyFirstTime : MonoBehaviour
{
    public GameObject checkImage;
    public GameObject startAnimation;
    public GameObject canvas2;

    private int check = 0;
    //private float animationEndTime=20f;
    //private float sceneStartTime = 0f;

    // Start is called before the first frame update
    void Start()
    {
        if (PlayerPrefs.HasKey("noMovieCheck"))
        {
            check = PlayerPrefs.GetInt("noMovieCheck");
            
        }
        else
        {
            check = 0;
        }

        if (check == 1)
        {
            //동영상 안보기 버튼 눌러져있으면
            startAnimation.SetActive(false);
            canvas2.SetActive(true);
            checkImage.SetActive(true);

        }
        else
        {
            canvas2.SetActive(false);
        }
    }
    void Update()
    {
        if(Time.time >= 20f)
        {
            
            startAnimation.SetActive(false);
            canvas2.SetActive(true);
        }
    }

    public void noMovieCheckButtonOn()
    {
        check = 1;
        checkImage.SetActive(true);
        PlayerPrefs.SetInt("noMovieCheck",1);
    }
}
