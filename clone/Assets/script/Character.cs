using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    float speed = 5.0f;
    float jump = 0.0f;

    // Update is called once per frame
    void Update()
    {
        // （右移動）
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position += speed * transform.right * Time.deltaTime;
        }

        // (左移動）
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position -= speed * transform.right * Time.deltaTime;
        }

        if(Input.GetKeyDown(KeyCode.UpArrow))
        {
            jump = 10.0f;
        }

        transform.position += jump * transform.up * Time.deltaTime;
        jump *= 0.98f;

    }
}
