using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody2D rb;

    public float speed = 5f;
    public float rotationSpeed;

    float x;
    float y;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        x = Input.GetAxis("Horizontal");
        y = Input.GetAxis("Vertical");
    }

    private void FixedUpdate()
    {
        Vector2 movement = new Vector2(x, y);

        if (Math.Abs(x) == 1 && Math.Abs(y) == 1)
            movement /= (float)Math.Sqrt(2);

        rb.velocity = movement * speed;

        if (x != 0 || y != 0)
        {
            float angle = Mathf.Atan2(movement.y, movement.x) * Mathf.Rad2Deg;
            transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(0, 0, angle), Time.fixedDeltaTime * rotationSpeed);
        }
    }
}
