using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Needle : FallingObject
{
    public override void getObject(nogomControllerStage2 nogomController)
    {
        nogomController.n_needle++;

        GameObject.Find("NeedleMarkerText").GetComponent<Text>().text = nogomController.n_needle + "/30";
    }
}
