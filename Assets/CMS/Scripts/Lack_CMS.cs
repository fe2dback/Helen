using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Lack_CMS : MonoBehaviour
{
    float rightMax = 2.0f;

    float leftMax = -29.0f;

    float currentPosition;

    float direction = 10.0f;
    // Start is called before the first frame update
    void Start()
    {
        currentPosition = transform.position.x;
        currentPosition = transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        currentPosition += Time.deltaTime * direction;

        if (currentPosition >= rightMax)

        {
            direction *= -1;
            currentPosition = rightMax;
        }
        else if (currentPosition <= leftMax)
        {
            direction *= -1;
            currentPosition = leftMax;
        }
        transform.position = new Vector3(currentPosition, 0, -6);
    }
}