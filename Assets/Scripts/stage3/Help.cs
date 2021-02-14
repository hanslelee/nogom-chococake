using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Help : MonoBehaviour
{
    public GameObject helpUI;
   
    public void help()
    {
        helpUI.SetActive(true);

        if (Input.GetMouseButtonDown(0))
        {
            helpUI.SetActive(false);
        }
    }
}
