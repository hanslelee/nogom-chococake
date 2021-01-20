using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class claGUI : MonoBehaviour
{
    private int m_nCount = 0;
    private TextMesh m_tmText;

    void Start()
    {
        m_tmText = (TextMesh)GameObject.Find("txtCount").GetComponent(typeof(TextMesh));
    }

    void OnGUI()
    {
        if (GUI.Button(new Rect(0
                                , 0
                                , 60
                                , 30)
                       , "버튼"))
        {
            //버튼 클릭시 작동할 코드.
            ++m_nCount;
            //Text 출력.
            m_tmText.text = "Count = " + m_nCount;
        }

    }
}
