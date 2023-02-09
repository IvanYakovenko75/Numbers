using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //referens
    public GameObject Player;
    public GameObject MovePlate;

    //positions
    private int xBoard = -1;
    private int yBoard = -1;

    //Coordinats
    public void SetCoords()
    {
        float x = xBoard;
        float y = yBoard;

        x = x * 0.66f;
        y = y * 0.66f;

        x += -2.3f;
        y += -2.3f;

        this.transform.position = new Vector3(x, y, -1.0f);
    }

    //public float speed = 5f;


    //if (transform.position.x > 1840)
    //{
    //    transform.position = new Vector2(-10, transform.position.y);

    //}

    //void FixedUpdate()
    //{
    //    if (Input.GetKey(KeyCode.W))
    //        transform.Translate(new Vector2(0, 1) * speed);

    //    if (Input.GetKey(KeyCode.S))
    //        transform.Translate(new Vector2(0, -1) * speed);


    //    if (Input.GetKey(KeyCode.D))
    //        transform.Translate(new Vector2(1, 0) * speed);

    //    if (Input.GetKey(KeyCode.A))
    //        transform.Translate(new Vector2(-1, 0) * speed);

    //}
}
