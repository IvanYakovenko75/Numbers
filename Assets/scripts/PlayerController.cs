using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5f;

    void Start()
    {

    }

    void Update()
    {
        //if (transform.position.x > 1840)
        //{
        //    transform.position = new Vector2(-10, transform.position.y);

        //}

    }

    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.W))
            transform.Translate(new Vector2(0, 1) * speed);

        if (Input.GetKey(KeyCode.S))
            transform.Translate(new Vector2(0, -1) * speed);


        if (Input.GetKey(KeyCode.D))
            transform.Translate(new Vector2(1, 0) * speed);

        if (Input.GetKey(KeyCode.A))
            transform.Translate(new Vector2(-1, 0) * speed);

    }
}
