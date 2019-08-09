using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Changeregreso1 : MonoBehaviour
{

    void OnTriggerEnter(Collider other)
    {
        //Codigo utilizado para que el jugador sea regresado al nivel 2. 
        if (other.gameObject.tag == "Player")
        {
            SceneManager.LoadScene("Nivel2");
        }
    }
}
