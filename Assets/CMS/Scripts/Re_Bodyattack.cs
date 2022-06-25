using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Re_Bodyattack : MonoBehaviour
{
    /* �ش� ��ũ��Ʈ�� ���� ������ TebbyBear�� �� ��ũ��Ʈ�̴�.
     * 1. �������� �ʿ��� ����
     * - ü��, ���ݷ�, ������, ��������, �̹��� �ٲ�, �ִϸ��̼�, �Ҹ�
     * 2. Ư�������� �ݺ��ؼ� �����̴� ����
     * 3. Ư�� ���������� �ݺ������� �����ϴ� ����
     * 4. �����ӿ� ���� �̹����� �ٲ�� ����
     * 5. �����̳� �ǰݽ� �Ҹ��� ���� ����
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