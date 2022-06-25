using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    public GameObject bullet;
    public Transform pos;
    public float cooltime;
    private float curtime;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (cooltime <= curtime)
        {
            if (Input.GetMouseButton(0))
            {
                Instantiate(bullet, pos.position, Quaternion.identity);
                curtime = 0f;
            }
        }
        curtime += Time.deltaTime;
    }
}
