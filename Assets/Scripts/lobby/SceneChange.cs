﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
    public void ChangeFirstScene()
    {
        SceneManager.LoadScene("Stage1");
    }
    public void ChangeSecondScene()
    {
        SceneManager.LoadScene("STAGE2");

    }
    public void ChangeThirdScene()
    {
        SceneManager.LoadScene("STAGE3 explanation");

    }
}
