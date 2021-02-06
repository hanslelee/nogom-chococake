using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nogomControllerStage2 : MonoBehaviour
{
    public int life = 3;

    void Start()
    {
    }

    void Update()
    {
        if (life <= 0)
            Die();
    }

    public void Die()
    {
        gameObject.SetActive(false);
    }
}
