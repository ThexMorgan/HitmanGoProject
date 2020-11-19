﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plController : MonoBehaviour
{
    public float speed = 5;
    public Rigidbody rb;

    void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0, moveVertical);

        rb.AddForce(movement * speed);
    }
}

