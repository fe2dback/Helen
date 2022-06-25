using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Re_Bodyattack : MonoBehaviour
{
    /* 해당 스크립트는 보스 몬스터인 TebbyBear에 들어갈 스크립트이다.
     * 1. 보스에게 필요한 정보
     * - 체력, 공격력, 움직임, 공격패턴, 이미지 바뀜, 애니메이션, 소리
     * 2. 특정구역을 반복해서 움직이는 로직
     * 3. 특정 공격패턴을 반복적으로 실행하는 로직
     * 4. 움직임에 따라 이미지가 바뀌는 로직
     * 5. 공격이나 피격시 소리가 나는 로직
     */

    
    public Image[] bossImage;
    public AudioSource[] bossSound;
    public GameObject player;
    public GameObject niddle;
    public Vector3 startPosition;
    private Vector3 niddlePos;
    public bool attackCheck = false;

    public float speed;

    void Start()
    {
        startPosition = transform.position;
        niddlePos = niddle.transform.position;
    }

    private void Update()
    {
       
        NiddleAttack();
    } 

    private void NiddleAttack()
    {
        if (attackCheck == true)
            niddle.transform.position = Vector3.Lerp(niddle.transform.position, player.transform.position, 0.5f);
        else if (attackCheck == false)
            niddle.transform.position = Vector3.Lerp(niddle.transform.position, niddlePos, 0.5f);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            
            attackCheck = true;
        } 
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            
            attackCheck = false;
        }
    }
}