using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Niddle : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            collision.gameObject.GetComponent<Rigidbody2D>().AddForce(Vector2.left * 30.0f, ForceMode2D.Impulse);
        }
        if (collision.gameObject.CompareTag("ammo"))
        {
            //HP -= 1;
            Debug.Log("hiting");
        }
    }
}

