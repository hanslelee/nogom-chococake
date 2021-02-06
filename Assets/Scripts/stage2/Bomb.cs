using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        Debug.Log("In OnTriggerEnter");
        if(other.tag=="Player")
        {
            Destroy(gameObject);

            nogomControllerStage2 nogomController = GetComponent<nogomControllerStage2>();

            if(nogomController!=null)
            {
                nogomController.life--;
            }
        }
    }
}
