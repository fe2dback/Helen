using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet_CMS : MonoBehaviour
{

    public float speed;
    public float distance;
    public LayerMask isLayer;
    PlayerMove playermove;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("DestoryBullet", 2);
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit2D raycast = Physics2D.Raycast(transform.position, transform.right * -1, distance, isLayer);
        if (raycast.collider != null)
        {
            if(raycast.collider.tag == "Player")
            {
                Debug.Log("¥Á«ﬂ¥Ÿ.!!!");
            }
        }
        transform.Translate(transform.right * -1f * speed * Time.deltaTime);
    }

    
void DestoryBullet()
    {
        Destroy(gameObject);
    }

}
