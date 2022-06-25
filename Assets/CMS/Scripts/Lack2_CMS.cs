using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lack2_CMS : MonoBehaviour
{
    Vector3 pos; //현재위치

    float delta = 29.0f; // 좌(우)로 이동가능한 (x)최대값

    float speed = 1.0f; // 이동속도




    void Start()
    {

        pos = transform.position;

    }


    void Update()
    {

        Vector3 v = pos;

        v.x += delta * Mathf.Sin(Time.time * speed);


        transform.position = v;

    }
}

