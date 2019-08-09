using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Changeregreso2 : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        //Codigo utilizado para que el jugador sea regresado hasta el nivel 1.
        if (other.gameObject.tag == "Player")
        {
            SceneManager.LoadScene("Nivel1");
        }
    }
}
