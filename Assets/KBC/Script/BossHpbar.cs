using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BossHpbar : MonoBehaviour
{
    [SerializeField]
    private Slider hpbar;

    private float maxHp = 100;
    private float curHp = 100;
    float imsi;
    
    void Start()
    {
        hpbar.value = (float)curHp / (float)maxHp;    
    }

     //Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if(curHp > 0)
            {
            curHp -= 10;
            
            }
             else
             {
             curHp = 0;
             }
             imsi = (float)curHp / (float)maxHp;
        }

        HandleHp();    
    }

    private void HandleHp()
    {
        hpbar.value = Mathf.Lerp(hpbar.value, (float)curHp / (float)maxHp, Time.deltaTime * 10);
        //hpbar.value = (float)curHp / (float)maxHp;
    }
}
