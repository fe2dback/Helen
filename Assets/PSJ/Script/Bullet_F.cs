using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet_F : MonoBehaviour
{
    public float speed;
    public PlayerMove playerMove;
    private float H;
    // Start is called before the first frame update
    
    void Start()
    {
        playerMove = FindObjectOfType<PlayerMove>();
        Invoke("DestroyBullet", 2);
        H = playerMove.h;
    }

    // Update is called once per frame
    void Update()
    {
            transform.Translate(new Vector2(H, 0) * speed * Time.deltaTime);

        /*else
        {
            transform.Translate(transform.right * -1 * speed * Time.deltaTime);
        }*/

    }
        
    void DestroyBullet()
    {
        Destroy(gameObject);
    }
}
