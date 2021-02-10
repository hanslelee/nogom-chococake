﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BrokenNeedle : FallingObject
{
    public override void getObject(nogomControllerStage2 nogomController)
    {
        GameManager2 gameManager2 = GameObject.Find("GameManager2").GetComponent<GameManager2>();
        if (gameManager2.n_needle > 0)
        {
            gameManager2.n_needle--;
            GameObject.Find("NeedleMarkerText").GetComponent<Text>().text = gameManager2.n_needle + "/30";
        }
    }
}
