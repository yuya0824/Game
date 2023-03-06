using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    float speed = 5.0f;
    float jump = 0.0f;


    bool waterture = true;
    int touchCount = 0;

    public GameObject Water;

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
            jump = 8.0f;
        }

        transform.position += jump * transform.up * Time.deltaTime;
        jump *= 0.98f;

    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Stage")
        {
            Debug.Log("Stage");
        }

        if (collision.gameObject.name == "goal")
        {
            Debug.Log("goal");
        }
    }

    void OnTriggerEnter2D(Collider2D coll)
    {

        if (coll.gameObject.name == "waterCollider" && waterture != false)
        {
            transform.localScale = new Vector3(1, 1, 1);

            if (touchCount == 3)
            {
                waterture = false;
            }

            touchCount += 1;
        }
    }
}
