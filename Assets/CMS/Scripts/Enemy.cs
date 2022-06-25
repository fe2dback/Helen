using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int BossHP = 10;
    public float distance;
    public float atkDistance;
    public LayerMask isLayer;
    public float speed;


    public GameObject bullet;
    public Transform pos;
    public Transform pos1;
    public Transform pos2;
    private void OnTriggerEnter2D(Collider2D collision)
    {

    
    }
    private void Update()
    {
        
    }
        void Start()
    {

    }
    public float cooltime;
    private float currenttime;
    void FixedUpdate()
    {
        RaycastHit2D raycast = Physics2D.Raycast(transform.position, transform.right * -1, distance, isLayer);
        if (raycast.collider != null)
        {
            if (Vector2.Distance(transform.position, raycast.collider.transform.position) < atkDistance)
            {
                if (currenttime <= 0)
                {
                    GameObject bulletcopy = Instantiate(bullet, pos.position, transform.rotation);

                    currenttime = cooltime;
                }
                currenttime -= Time.deltaTime;
            }
        }
    }
}
