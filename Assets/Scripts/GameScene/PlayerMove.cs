using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    [SerializeField]public float speed;
    public float horizontalMove;

    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        Move();
    }

    private void Move()
    {
        horizontalMove = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(horizontalMove * speed * Time.deltaTime, rb.velocity.y);

        Vector2 newScale = transform.localScale;
        
        if (horizontalMove > 0)
        {
            newScale.x = 0.3f;
        }
        else if (horizontalMove < 0)
        {
            newScale.x = -0.3f;
        }

        transform.localScale = newScale;
    }
}
