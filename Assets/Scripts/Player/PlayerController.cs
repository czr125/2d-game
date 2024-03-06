using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody2D rb;
    private float moveX;

    public float speed;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        moveX = Input.GetAxisRaw("Horizontal");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate()
    {
        Move();
    }

    void Move()
    {
        rb.velocity = new Vector2(moveX * speed, rb.velocity.y);
    }
}
