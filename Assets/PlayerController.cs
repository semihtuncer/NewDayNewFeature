using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;
    public Transform rotator;

    public float horizontal;
    public float vertical;

    Rigidbody2D rb;

    void Start()
    {
        rb= GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");

        rb.AddForce(vertical * rotator.up * speed);
        rotator.Rotate(Vector3.forward, horizontal * -1.5f);
    }
}
