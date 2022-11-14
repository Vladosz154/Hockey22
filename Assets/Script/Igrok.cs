using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Igrok : MonoBehaviour
{
    private Vector2 mouse;
    Rigidbody2D RB;
    void Start()
    {
        RB = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            mouse = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            if(mouse.x <= 7.9 && mouse.x >= 0.12 && mouse.y <= 2.8 && mouse.y >= -2.75)
            {
                RB.MovePosition(mouse);
            }
        }
    }
}
