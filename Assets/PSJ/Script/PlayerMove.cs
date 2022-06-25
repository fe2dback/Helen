using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float maxSpeed;
    public float jumpPower;
    public float jumpstack;
    public int HP = 5;
    public float DG;
    public float h = 1.0f;
    Rigidbody2D rigid;
    Animator anim;
    SpriteRenderer spriteRenderer;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        if (collision.CompareTag("Enemy")) //EnemyTag 닿은 개체
        {
            HP -= 1;
            //Debug.Log("hit");
            //Debug.Log(HP);
        }
        
        


    }


    private void Start()
    {
        
    }

    private void Awake()
    {
        rigid = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }
    private void Update()
    {
        //hit
        if (HP <= 0)
        {
            Debug.Log("Die");
            OnApplicationQuit(); //죽을시 강종코드

        }

        //Jump
        if (Input.GetButtonDown("Jump") && !anim.GetBool("isJumping"))
            
        {
            rigid.AddForce(Vector2.up * jumpPower, ForceMode2D.Impulse);
            anim.SetBool("isJumping", true);
            jumpstack++;//S
            

        }

        
        //stop Speed
        if (Input.GetButtonUp("Horizontal"))
        {

            rigid.velocity = new Vector2(rigid.velocity.normalized.x * 0.5f, rigid.velocity.y);
        }

        //animation
        if (Mathf.Abs(rigid.velocity.x) < 0.3)
            anim.SetBool("isWalking", false);
        else
            anim.SetBool("isWalking", true);
        
       

    }
    private void FixedUpdate()
    {
        //Move Speed
        h = Input.GetAxisRaw("Horizontal");


        if (h < 0)
        {
            transform.rotation = Quaternion.Euler(0, 180, 0);
        }
        else if (0 < h)
        {
            transform.rotation = Quaternion.Euler(0, 0, 0);
        }

        rigid.AddForce(Vector2.right * h, ForceMode2D.Impulse);

        if (rigid.velocity.x > maxSpeed)
            rigid.velocity = new Vector2(maxSpeed, rigid.velocity.y); 

        else if (rigid.velocity.x < maxSpeed * (-1))
            rigid.velocity = new Vector2(maxSpeed * (-1), rigid.velocity.y);

        //Landing PlatForm
        if (rigid.velocity.y < 0)
        {
            Debug.DrawRay(rigid.position, new Vector3(0, -2.6f, 0), new Color(0, 1, 0));

            RaycastHit2D rayHit = Physics2D.Raycast(rigid.position, Vector3.down, 2.6f, LayerMask.GetMask("Platform"));

            if (rayHit.collider != null)
            {
                if (rayHit.distance < 3f)
                    anim.SetBool("isJumping", false);
            }
        }
        
    }
    //강종 스크립트
    private void OnApplicationQuit()

    {
        Application.CancelQuit();
        System.Diagnostics.Process.GetCurrentProcess().Kill();
    }

}
