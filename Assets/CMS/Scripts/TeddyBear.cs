using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TeddyBear : MonoBehaviour
{
    /* �ش� ��ũ��Ʈ�� ���� ������ TebbyBear�� �� ��ũ��Ʈ�̴�.
     * 1. �������� �ʿ��� ����
     * - ü��, ���ݷ�, ������, ��������, �̹��� �ٲ�, �ִϸ��̼�, �Ҹ�
     * 2. Ư�������� �ݺ��ؼ� �����̴� ����
     * 3. Ư�� ���������� �ݺ������� �����ϴ� ����
     * 4. �����ӿ� ���� �̹����� �ٲ�� ����
     * 5. �����̳� �ǰݽ� �Ҹ��� ���� ����
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
    /* BodyAttack ��ũ��Ʈ�� ���� �������� �÷��̾ �����ϸ� �÷��̾�� �ε��� �Ŀ� �������� �ش�.
     * 1. �÷��̾� ������ �����´� (��ġ��)
     * 2. ���� �������� Trigger�ȿ� �÷��̾ ���´ٸ� �÷��̾�� ������ �����Ŀ� ���� ��ġ�� ���ƿ´�.
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
        /* �ش� ��ũ��Ʈ���� ū ���׶�̾ȿ� ������ ������
         * �ش� ���� ���ӿ�����Ʈ�� �� �÷��̾�� ���ٽ�Ų��.
         */
        Debug.Log("�� �浹");
        transform.position = new Vector2(player.transform.position.x, 0);

        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        /* �ش� ��ũ��Ʈ���� ���� ������Ʈ�� �簢�� �ݶ��̴��� ��뿡�� �ε����ٸ�
         * ��� �÷��̾� ���� ������Ʈ�� ü���� ��´� ���� ���� ��ġ�� ���ư���
         */
        Debug.Log("�簢�� �浹");
        Debug.Log("����10");
        transform.position = new Vector2(player.transform.position.x + 5, 0);


    }
}
