using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TeddyBear : MonoBehaviour
{
    /* 해당 스크립트는 보스 몬스터인 TebbyBear에 들어갈 스크립트이다.
     * 1. 보스에게 필요한 정보
     * - 체력, 공격력, 움직임, 공격패턴, 이미지 바뀜, 애니메이션, 소리
     * 2. 특정구역을 반복해서 움직이는 로직
     * 3. 특정 공격패턴을 반복적으로 실행하는 로직
     * 4. 움직임에 따라 이미지가 바뀌는 로직
     * 5. 공격이나 피격시 소리가 나는 로직
     */

    public int bossHP = 100;
    public int bossDamage = 10;
    public Image[] bossImage;
    public AudioSource[] bossSound;
    public GameObject player;
    public GameObject bodyAttackDis;
    Animator anim;

    void Start()
    {
        
    }

    void Update()
    {
        
    }
    /* BodyAttack 스크립트는 일정 범위내에 플레이어가 접근하면 플레이어에게 부딪힌 후에 데미지를 준다.
     * 1. 플레이어 정보를 가져온다 (위치값)
     * 2. 일정 범위내의 Trigger안에 플레이어가 들어온다면 플레이어에게 빠르게 접근후에 원래 위치로 돌아온다.
     */
    private void BodyAttack()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Debug.Log("sens");
            anim.SetBool("ted", false);
        }
        /* 해당 스크립트에는 큰 동그라미안에 상대방이 들어오면
         * 해당 보스 게임오브젝트를 적 플레이어게 접근시킨다.
         */
        Debug.Log("원 충돌");
        transform.position = new Vector2(player.transform.position.x, 0);

        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        /* 해당 스크립트에는 보스 오브젝트의 사각형 콜라이더가 상대에게 부딪힌다면
         * 상대 플레이어 게임 오브젝트의 체력을 깎는다 그후 원래 위치로 돌아간다
         */
        Debug.Log("사각형 충돌");
        Debug.Log("피해10");
        transform.position = new Vector2(player.transform.position.x + 5, 0);


    }
}
