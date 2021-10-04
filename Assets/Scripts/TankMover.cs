﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankMover : MonoBehaviour {
    public Rigidbody rb;
    public TankData data;

    // Use this for initialization
    void Start() {
        //Load the rigibody.
        rb = this.gameObject.GetComponent<Rigidbody>();
        //Load the data.
        data = GetComponent<TankData>();
    }

    // Update is called once per frame
    void Update() {

    }

    public void MoveForward()
    {
        rb.MovePosition(rb.position + transform.forward * data.speed * Time.deltaTime);
    }

    public void Back()
    {
       rb.MovePosition(rb.position + transform.forward * data.speed * Time.deltaTime);
    }
    public void Rotate()
    {
        transform.Rotate(0, data.turnSpeed * Time.deltaTime, 0);
    }
}
