using System.Collections;
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

    // Codigos utilizados para el movimiento exacto de mi player.
        if (Input.GetKey(KeyCode.W))
        {
            myTransform.Translate(new Vector3(0, 0, Velocidad) * Time.deltaTime);
            //Codigo para moverse hacia arriba.
        }

        if (Input.GetKey(KeyCode.S))
        {
            myTransform.Translate(new Vector3(0, 0, -Velocidad) * Time.deltaTime);
            //Codigo para moverse hacia abajo.
        }

        if (Input.GetKey(KeyCode.A))
        {
            myTransform.Translate(new Vector3(-Velocidad, 0, 0) * Time.deltaTime);
            //Codigo para moverse hacia la izquierda.
        }

        if (Input.GetKey(KeyCode.D))
        {
            myTransform.Translate(new Vector3(Velocidad, 0, 0) * Time.deltaTime);
            //Codigo para moverse hacia la derecha.
        }

    }
}
