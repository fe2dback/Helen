using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lack2_CMS : MonoBehaviour
{
    Vector3 pos; //������ġ

    float delta = 29.0f; // ��(��)�� �̵������� (x)�ִ밪

    float speed = 1.0f; // �̵��ӵ�




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

