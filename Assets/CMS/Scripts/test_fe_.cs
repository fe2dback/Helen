using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class test_fe_ : MonoBehaviour
{

    public string transferMapName;
    public int BossHP;


    // Start is called before the first frame update
    void Start()
    {
       
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.CompareTag("ammo")) //EnemyTag ¥Í¿∫ ∞≥√º
        {
            BossHP -= 1;
            //Debug.Log("hit");
            //Debug.Log(HP);
        }

    }

    // Update is called once per frame
    void Update()
    {

        //hit
        if (BossHP <= 0)
        {
            Debug.Log("B_Die");
            SceneManager.LoadScene(transferMapName);
        }
    }

}
    
