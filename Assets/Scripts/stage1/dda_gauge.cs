using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class dda_gauge : MonoBehaviour
{
    [SerializeField]
    private Slider dda_bar;

    private float maxHp = 100;
    private float curHp = 100;
    private float minusHp = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        dda_bar.value = (float)curHp / (float)maxHp;
        minusHp = 1 / maxHp;
    }

    // Update is called once per frame
    void Update()
    {
        if(dda_bar.value != maxHp)
            dda_bar.value += minusHp * Time.deltaTime;
    }

    private void HandleHp()
    {
        dda_bar.value = Mathf.Lerp(dda_bar.value, (float)curHp / (float)maxHp, Time.deltaTime * 10);
    }
}
