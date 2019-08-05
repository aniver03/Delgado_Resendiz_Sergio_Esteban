﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour
{

    private Transform myTransform;
    private Rigidbody cubeRigidBody;
    public float Velocidad;
    public float jumpHight = 100;

    // Start is called before the first frame update
    void Start()
    {
        myTransform = GetComponent<Transform>();
        cubeRigidBody = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            myTransform.Translate(new Vector3(0, 0, Velocidad) * Time.deltaTime);

        }

        if (Input.GetKey(KeyCode.S))
        {
            myTransform.Translate(new Vector3(0, 0, -Velocidad) * Time.deltaTime);

        }

        if (Input.GetKey(KeyCode.A))
        {
            myTransform.Translate(new Vector3(-Velocidad, 0, 0) * Time.deltaTime);

        }

        if (Input.GetKey(KeyCode.D))
        {
            myTransform.Translate(new Vector3(Velocidad, 0, 0) * Time.deltaTime);

        }

    }
}
